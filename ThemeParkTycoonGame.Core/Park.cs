using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Core
{
    public class Park : GameObject
    {
        public delegate void NameChangingEvent(object sender, NameChangingEventArgs e);
        public event NameChangingEvent NameChanging;

        public delegate void GuestEnteredEvent(object sender, GuestEnteredEventArgs e);
        public event GuestEnteredEvent GuestEntered;

        public delegate void WeatherChangedEvent(object sender, WeatherChangedEventArgs e);
        public event WeatherChangedEvent WeatherChanged;

        public GuestList Guests;
        public Wallet ParkWallet;
        public ParkInventory ParkInventory;
        public decimal EntryFee;

        public GuestController GuestController;

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                DoNameChange(value);
            }
        }

        private Weather currentWeather;
        public Weather CurrentWeather
        {
            get
            {
                return currentWeather;
            }
            set
            {
                DoChangeWeather(value);
            }
        }

        private List<Desire> desirables;

        public Park()
        {
            Guests = new GuestList();
            Guests.GuestAdded += Guests_GuestAdded;

            ParkWallet = new Wallet();

            ParkInventory = new ParkInventory();
            ParkInventory.InventoryChanged += ParkInventory_InventoryChanged;

            EntryFee = 15;

            desirables = new List<Desire>();

            GuestController = new GuestController(desirables, ref Guests);
            GuestController.MinimumCash = EntryFee; // TODO: when entryfee changes, this MinimumCash needs to as well.

            this.WeatherChanged += Park_WeatherChanged;

            // Start with 20k
            ParkWallet.SubtractFromBalance(-20000, "Starting cash for running the park");

            // Start with random weather
            DoChangeWeather();
        }

        private void ParkInventory_InventoryChanged(object sender, InventoryChangedEventArgs e)
        {
            // Update the list of things people desire, when the inventory gains a ride or shop
            desirables = new List<Desire>();

            foreach (BuildableObject rideOrShop in ParkInventory.All)
            {
                rideOrShop.ParentWallet = ParkWallet; // TODO: This is getting chaotic, re-think structure!!!

                if (!(rideOrShop is Shop) && !(rideOrShop is Ride))
                {
                    throw new ArgumentException("Not a ride or shop from inventory. Can't desire");
                }

                desirables.Add(new Desire()
                {
                    Object = (IDesirable) rideOrShop,
                    Specific = null, // e.g: What drink, food or seat on a coaster?
                });
            }

            GuestController.Desirables = desirables;
        }

        private void Guests_GuestAdded(object sender, GuestAddedEventArgs e)
        {
            if (GuestEntered != null)
                GuestEntered.Invoke(this, new GuestEnteredEventArgs(e.Guest));
        }

        private void Park_WeatherChanged(object sender, WeatherChangedEventArgs e)
        {
            GuestController.EntryChanceMultiplier = e.Weather.Multiplier;
        }

        public void DoChangeWeather(Weather weather = null)
        {
            // If no weather is given a random weather type should be selected.
            if(weather == null)
            {
                weather = Weather.GetRandom();
            }

            // Check if someone is handling this event
            if (WeatherChanged != null)
            {
                WeatherChanged.Invoke(this, new WeatherChangedEventArgs()
                {
                    OldWeather = this.CurrentWeather,
                    Weather = weather
                });
            }

            currentWeather = weather;
        }

        public void DoNameChange(string newName)
        {
            // Create event arguments that will inform the event handlers
            NameChangingEventArgs eventArgs = new NameChangingEventArgs()
            {
                OldParkName = this.name,
                ParkName = newName,
                Handled = false,
            };

            // Check if any event handlers are set
            if (NameChanging != null)
            {
                NameChanging(this, eventArgs);
            }

            // Let event handlers override this behaviour and stop the park name change.
            if (!eventArgs.Handled)
            {
                // In this case if the event is not handled, it will default to changing the name of the park.
                // This means that if an event handler indicates the event is handled, the name will not change automatically.
                name = newName;
            }
        }
    }

    public class NameChangingEventArgs : EventArgs
    {
        public bool Handled;
        public string OldParkName;
        public string ParkName;
    }

    public class GuestEnteredEventArgs : EventArgs
    {
        public Guest Guest;

        public GuestEnteredEventArgs(Guest guest)
        {
            Guest = guest;
        }
    }

    public class WeatherChangedEventArgs : EventArgs
    {
        public Weather OldWeather;
        public Weather Weather;
    }
}
