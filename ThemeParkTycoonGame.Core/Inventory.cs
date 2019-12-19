using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Core
{
    public abstract class Inventory
    {
        public delegate void InventoryChangedEvent(object sender, InventoryChangedEventArgs e);
        public abstract event InventoryChangedEvent InventoryChanged;

        public Inventory()
        {

        }

    }

    public class InventoryChangedEventArgs : EventArgs
    {
        public Inventory Inventory;

        public InventoryChangedEventArgs(Inventory inventory)
        {
            this.Inventory = inventory;
        }
    }
}
