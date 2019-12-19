using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Core
{
    public class ParkInventory : Inventory
    {
        public override event InventoryChangedEvent InventoryChanged;

        public ObservableCollection<Shop> Shops;
        public ObservableCollection<Ride> Rides;

        // Returns a list with both shops and rides
        public List<BuildableObject> All
        {
            get
            {
                List<BuildableObject> all = new List<BuildableObject>();

                foreach (Shop item in Shops)
                    all.Add(item);

                foreach (Ride item in Rides)
                    all.Add(item);

                return all;
            }
        }

        public ParkInventory()
        {
            Shops = new ObservableCollection<Shop>();
            Rides = new ObservableCollection<Ride>();

            Shops.CollectionChanged += Object_CollectionChanged;
            Rides.CollectionChanged += Object_CollectionChanged;
        }

        internal void Add(BuildableObject buildableObject)
        {
            buildableObject.ParentInventory = this;

            if (buildableObject is Shop)
                Shops.Add(buildableObject as Shop);
            else if (buildableObject is Ride)
                Rides.Add(buildableObject as Ride);
            else
                throw new ArgumentException("Tried to add something other than shop or ride to inventory!");
        }

        public BuildableObject GetByName(string itemName)
        {
            foreach (Shop item in Shops)
                if (item.Name == itemName)
                    return item;

            foreach (Ride item in Rides)
                if (item.Name == itemName)
                    return item;

            return null;
        }

        private void Object_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (InventoryChanged != null)
            {
                InventoryChangedEventArgs eventArgs = new InventoryChangedEventArgs(this);

                InventoryChanged.Invoke(this, eventArgs);
            }
        }

        // Checks whether we already have a ride
        public bool Contains(BuildableObject ride)
        {
            foreach (Ride inventoryRide in Rides)
            {
                if(ride == inventoryRide)
                {
                    return true;
                }
            }

            return false;
        }

        // Checks whether we already have a shop
        public bool Contains(Shop shop)
        {
            foreach (Shop inventoryShop in Shops)
            {
                if (shop == inventoryShop)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
