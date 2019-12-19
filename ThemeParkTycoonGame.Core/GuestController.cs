using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Core
{
    public class GuestController
    {
        public const int TICK_TIMEOUT = 1500;
        public const float CHANCE_ENTER_PARK = 0.5f;
        public const ushort MAX_DECISION_CYCLES = 3;

        private GuestList targetGuests;
        private bool hasTicked;
     
        private System.Timers.Timer warningTimer; // Code support

        public decimal MinimumCash; // Minimum cash a guest will have EntryFee for example
        public float EntryChanceMultiplier;
        public List<Desire> Desirables;

        // Get the drink from ObjectSpecifics.All, make peeps want it. Sell it at python (because testing dont need shops yet)

        // Provide which guests this controller handles
        public GuestController(List<Desire> desirables, ref GuestList targets)
        {
            this.Desirables = desirables;
            this.targetGuests = targets;

            // Show an exception if someone forgot to call 'DoTick' in their code
            StartWarningCountdown();
        }

        public void DoTick(int interval)
        {
            Tick(interval);
         
        }

        // A tick is a 'think' and as seen in the Start() methode happens at 1000ms intervals
        private void Tick(int interval)
        {
            hasTicked = true;
        

            /*
             * Test script to make everyone go to the python
             */
            // Get the python from the park inventory
            //BuildableObject python = this.park.ParkInventory.GetByName("Python");

            //// Does the inventory not contain python? (User hasn't purchased it yet)
            //if (python == null)
            //    return;

            //// Go to Python, ride it and get bonus        
            //foreach (Guest guest in this.targets)
            //{
            //    if(guest.Desires.Count < 1)
            //    {
            //        Desire wants = new Desire()
            //        {
            //            Object = python,
            //            Reason = "I feel compeled to go to the Python",
            //        };

            //        guest.Desires.Enqueue(wants);
            //    }
            //}
            /*
             * End of test script to make everyone go to the python
             */
            // Based on the weather, a certain chance of a guest coming inside
            if (shouldGuestEnter())
            {
                // Add a random guest to the park
                targetGuests.Add(getNewRandomGuest());
            }

            // For all guests that don't have a goal: give them one
            var guestsWithoutDesire = targetGuests.Where(g => g.Desires.Count == 0);

            foreach (Guest guestWithoutDesire in guestsWithoutDesire)
            {
                giveDesires(guestWithoutDesire);
            }

            // Let all guests act upon their desires.
            foreach (Guest guest in targetGuests)
            {
                guest.FollowDesire();
            }
        }

        private void giveDesires(Guest guest)
        {
            ushort cycles = 0;

            // Try a few times if the guest doesn't want any desires
            while(cycles++ < MAX_DECISION_CYCLES)
            {
                Desire foundDesire = giveDesireByAvailability(guest);

                if (foundDesire != null)
                    break;

                // If we didn't get desires by availability, we will want something based on our stats.
                foundDesire = giveDesireByStats(guest);

                if (foundDesire != null)
                    break;

                // TODO: Leave park
            }
        }

        private Desire giveDesireByStats(Guest guest)
        {
            // Go through all stats and decide wether we have cravings.
            float cravings = 40;
            IDesirable desirable = null;
            ObjectSpecific objectSpecific = null;

            foreach (var stat in guest.CurrentStats)
            {
                // If we aren't craving this stat, continue to the next stat.
                if (stat.Value < cravings)
                    continue;

                switch (stat.Type.UniqueId)
                {
                    case "hunger":
                        {
                            desirable = (IDesirable)Marketplace.Instance.GetRandomBuyableObject(ObjectSpecific.Types.Food);
                            //objectSpecific =
                            break;
                        }
                    case "thirst":
                        {
                            desirable = (IDesirable)Marketplace.Instance.GetRandomBuyableObject(ObjectSpecific.Types.Drink);
                            //objectSpecific =
                            break;
                        }
                    case "excitement":
                        {
                            desirable = (IDesirable)Marketplace.Instance.GetRandomBuyableObject(ObjectSpecific.Types.Exciting);
                            //objectSpecific =
                            break;
                        }
                }

                //if (desirable == null)
                    //throw new NotImplementedException("Add implementation for this desire!");

                // If we've come here we have a desirable. We only want 1 thing.
                break;
            }

            if (desirable == null)
                return null;

            // If we desire something out of our stats, enqueue it on our desire list
            Desire desire = new Desire()
            {
                Object = desirable,
                Specific = objectSpecific
            };

            // Show that this ride/shop doesn't exist yet = (Unavailable)
            // TODO: Change this to say something like "I would love to go on something more exciting than X"
            desire.Reason = string.Format("(Unavailable) " + desire.Object.GetRandomDesireReason(), desire.Object);

            guest.Desires.Enqueue(desire);

            return desire;
        }

        private Desire giveDesireByAvailability(Guest guest)
        {
            // Go through all desirable things (shops, rides) and see if we want them enough.
            float enough = 25;
            foreach (var desire in Desirables)
            {
                // Do not desire things if we already desire them
                if (guest.Desires.Contains(desire))
                    continue;

                // Apply stat modifiers to chance for this desire 
                // Hunger > 50   =   +desire to eat     +a bit desire to ride intense rides
                // Nauseous > 50 =   -desire to ride intense rides  +desire for bathroom

                if (desire.Object is Ride)
                {
                    if (guest.GetStat("want_for_ride").Value < enough)
                    {
                        // We do not want this enough. Continue to next desire
                        continue;
                    }
                }
                else if (desire.Object is Shop)
                {
                    if (desire.Specific.Category == ObjectSpecific.Types.Food
                        && guest.GetStat("hunger").Value < enough)
                    {
                        // We do not want this enough. Continue to next desire. etc...
                        continue;
                    }
                    else if (desire.Specific.Category == ObjectSpecific.Types.Drink
                       && guest.GetStat("thirst").Value < enough)
                    {
                        continue;
                    }
                }

                // TODO See if chance makes us like them (stats will make things more/less likely)
                desire.Reason = string.Format(desire.Object.GetRandomDesireReason(), desire.Object);
                guest.Desires.Enqueue(desire);

                return desire;
            }

            return null;
        }

        private bool shouldGuestEnter()
        {
            double nextGuestEnterParkChance = NumberGenerator.NextDouble();

            // Lower/increase the chance based on weather
            nextGuestEnterParkChance *= EntryChanceMultiplier;

            if(nextGuestEnterParkChance < CHANCE_ENTER_PARK)
            {
                return true;
            }

            Debug.WriteLine("Did not let a new guest enter park. It wasn't their day");
            Debug.WriteLine(EntryChanceMultiplier);
            Debug.WriteLine(nextGuestEnterParkChance);
            Debug.WriteLine("====");

            return false;
        }

        private Guest getNewRandomGuest()
        {
            List<Stat> stats = new List<Stat>();
            Guest guest = new Guest()
            {
                CurrentStats = stats,
                // Chosen at random bring between 50 and 150 cash into the park
                Wallet = new Wallet(NumberGenerator.Next((int) MinimumCash, (int)MinimumCash + 70)),
            };

            var statTypes = StatTypes.FindByTarget(GameObjectType.Guest);

            // When a guest enters, their stats are randomly generated
            foreach (var statType in statTypes)
            {
                stats.Add(new Stat()
                {
                    Type = statType,
                    Value = statType.GetBaseValue(guest)
                });
            }

            return guest;
        }

        internal void StartWarningCountdown()
        {
            if (warningTimer != null)
                return;

            hasTicked = false;
            warningTimer = new System.Timers.Timer();
            warningTimer.Elapsed += WarningTimer_Elapsed;
            warningTimer.Interval = TICK_TIMEOUT; // number of milliseconds between each tick
            warningTimer.Start();
        }

        private void WarningTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if(!hasTicked)
                throw new Exception("Tick timed out! This means you didn't call 'GuestController.DoTick()' anywhere! You should call DoTick at least every " + TICK_TIMEOUT + "milliseconds.");
        }
    }
}
