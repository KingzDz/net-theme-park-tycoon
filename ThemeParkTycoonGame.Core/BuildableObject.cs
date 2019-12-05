using System;
using System.Collections.Generic;

namespace ThemeParkTycoonGame.Core
{
    public abstract class BuildableObject : GameObject
    {
        public string Name;
        public object Image; // object, because .NET Standard doesn't support System.Drawing. 
        // If we remember we put an image in a variable of type 'object', we can always get it out. Despite this being an 'object'.
        // Remember that everything inherits from object. Everything is an object.
        public decimal EntryFee;
        public decimal Cost;

        public ParkInventory ParentInventory;
        public Wallet ParentWallet;

        public ObjectSpecific.Types[] ServesTypes { get; protected set; }

        public override string ToString()
        {
            return Name;
        }

        public void Consume(Guest guest)
        {
            // Add EntryFee to our parent wallet
            this.ParentWallet.SubtractFromBalance(-EntryFee, guest.Name);
        }

        public void AddToInventory(ParkInventory toInventory)
        {
            toInventory.Add(this);
        }
    }
}