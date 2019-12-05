using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Core
{
    public class Guest : GameObject
    {
        public delegate void ActionChangedEvent(object sender, ActionChangedEventArgs e);
        public event ActionChangedEvent ActionChanged;

        public string Name;
        public Wallet Wallet;
        public DateTime? TimeEntered;
        public Desire CurrentDesire { get; private set; }
        public GuestInventory Inventory { get; set; }

        // An observable queue can be monitored
        public ObservableQueue<Desire> Desires;

        public Guest()
            :base()
        {
            // When a guest is first created, give them a random name!
            Name = NameGenerator.NextName();

            // Give this guest a wallet with 100 bucks
            Wallet = new Wallet();

            // Give an empty inventory
            Inventory = new GuestInventory();

            // Give a guest basics stats
            foreach (StatType statType in StatTypes.FindByTarget(GameObjectType.Guest))
            {
                float asd = statType.GetBaseValue(this);

                CurrentStats.Add(new Stat()
                {
                    Type = statType,
                    Value = asd
                });
            }

            Desires = new ObservableQueue<Desire>();
            // React when an item is added or removed from the queue
            Desires.CollectionChanged += Guest_DesiresChanged;

            RefreshDesires();
        }

        public Stat GetStat(string uniqueId)
        {
            foreach (Stat stat in CurrentStats)
            {
                if (stat.Type.UniqueId == uniqueId)
                    return stat;
            }

            return null;
        }

        public void FollowDesire()
        {
            // If we have no desires, stop this method and go back
            if (Desires.Count == 0)
                return;

            Desire desireToFollow = Desires.Peek();

            // Can't follow desire, because the park doesn't have it.
            // TODO: Lower excitement
            if (!desireToFollow.Object.IsAvailable())
                return;

            // Actually take the desire from the list
            desireToFollow = Desires.Dequeue();

            if(desireToFollow.Object is BuildableObject)
            {
                var buildableObject = desireToFollow.Object as BuildableObject;

                buildableObject.Consume(this);

                this.Wallet.SubtractFromBalance(buildableObject.EntryFee, "(Fulfilled) " + desireToFollow.Reason);
            }

            // TODO: Do something with the object (like become damaged, or use products in stock)
            //desireToFollow.Object.

            // TODO: Apply the rides' boost after riding the ride
        }

        private void RefreshDesires()
        {
            Desire oldAction = this.CurrentDesire;

            // If there are no items in the desires collection, we just go idle
            if (Desires.Count == 0)
            {
                this.CurrentDesire = new Desire()
                {
                    Reason = "Walking around aimlessly...",
                    GainedAt = DateTime.Now,
                };
            }
            else
            {
                // Set our new interest to the first item in the queue
                this.CurrentDesire = Desires.Peek();
            }

            if (ActionChanged != null)
                ActionChanged.Invoke(this, new ActionChangedEventArgs(oldAction.Reason, this.CurrentDesire.Reason));
        }

        public override string ToString()
        {
            return Name;
        }

        private void Guest_DesiresChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            RefreshDesires();
        }

        public class ActionChangedEventArgs : EventArgs
        {
            public string OldAction;
            public string Action;

            public ActionChangedEventArgs(string oldAction, string currentAction)
            {
                OldAction = oldAction;
                Action = currentAction;
            }
        }
    }
}
