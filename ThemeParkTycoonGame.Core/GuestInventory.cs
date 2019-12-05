using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Core
{
    public class GuestInventory : Inventory
    {
        public override event InventoryChangedEvent InventoryChanged;

        // Returns a list with all the guests products (drinks, foods, maps)
        public List<Product> All
        {
            get
            {
                return Products.ToList();
            }
        }

        public ObservableCollection<Product> Products;

        public GuestInventory()
        {
            Products = new ObservableCollection<Product>();

            Products.CollectionChanged += Object_CollectionChanged;
        }

        public Product GetByName(string itemName)
        {
            foreach (Product item in Products)
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

        // Checks whether we already have a certain product
        public bool Contains(Product product)
        {
            foreach (Product inventoryProduct in Products)
            {
                if(product == inventoryProduct)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
