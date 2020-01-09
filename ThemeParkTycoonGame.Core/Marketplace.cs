using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Core
{
    public class Marketplace
    {
        private static Marketplace instance;

        private List<BuildableObject> purchasableObjects;
        private List<BuildableObject> purchasedObjects;

        // Marketplace is a singleton, this is the way to get an instance
        public static Marketplace Instance
        {
            get
            {
                // Make an instance only once
                if (instance == null)
                    instance = new Marketplace();

                // Then always return that instance
                return instance;
            }
        }

        // Marketplace is a singleton. This constructor is therefor private (so only GetInstance can make an instance)
        private Marketplace()
        {
            purchasableObjects = new List<BuildableObject>();

            // Configure the rides and shops that are available here
            purchasableObjects.AddRange(Rides.All);

            purchasedObjects = new List<BuildableObject>();
        }

        public void Buy(BuildableObject rideOrShop, Wallet fromWallet, ParkInventory toInventory)
        {
            if (fromWallet.Balance < rideOrShop.Cost)
            {
                throw new ArgumentException("Wallet does not have enough money! Check balance in the UI before calling this method.");
            }

            if (toInventory.Contains(rideOrShop))
            {
                throw new ArgumentException("Inventory already contains this item! Check if player owns the item before calling this method.");
            }

            rideOrShop.AddToInventory(toInventory);

            purchasedObjects.Add(rideOrShop);

            // Always deduct the money
            fromWallet.SubtractFromBalance(rideOrShop.Cost, "Bought " + rideOrShop.Name);
        }

        // Takes the current inventory, so already purchased rides can be hidden
        public List<Ride> GetBuyableRides(ParkInventory currentInventory)
        {
            List<Ride> buyableRides = new List<Ride>();

            foreach (BuildableObject item in purchasableObjects)
            {
                if (!(item is Ride))
                    continue;

                // If the player already has the item
                if (currentInventory.Contains(item))
                    continue;

                // If the item has already been purchased
                if (purchasedObjects.Contains(item))
                    continue;

                buyableRides.Add(item as Ride);
            }

            return buyableRides;
        }

        // Takes the current inventory, so already purchased rides can be hidden
        public List<Shop> GetBuyableShops(ParkInventory currentInventory)
        {
            List<Shop> buyableShops = new List<Shop>();

            foreach (BuildableObject item in purchasableObjects)
            {
                if (!(item is Shop))
                    continue;

                // If the player already has the item
                if (currentInventory.Contains(item))
                    continue;

                // If the item has already been purchased
                if (purchasedObjects.Contains(item))
                    continue;

                buyableShops.Add(item as Shop);
            }

            return buyableShops;
        }

        // Returns all rides and shops by what they serve
        public List<BuildableObject> GetBuyableObjects(ObjectSpecific.Types objectSpecificType)
        {
            var objects = new List<BuildableObject>();

            foreach (var rideOrShop in purchasableObjects)
            {
                if (rideOrShop.ServesTypes.Contains(objectSpecificType))
                    objects.Add(rideOrShop);
            }

            return objects;
        }

        // Returns a single random rides and shops by what they serve
        public BuildableObject GetRandomBuyableObject(ObjectSpecific.Types objectSpecificType)
        {
            var objects = GetBuyableObjects(objectSpecificType);

            return objects[NumberGenerator.Next(objects.Count)];
        }

        public static implicit operator string(Marketplace v)
        {
            throw new NotImplementedException();
        }
    }
}
