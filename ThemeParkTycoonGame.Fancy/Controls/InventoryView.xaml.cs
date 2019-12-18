using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThemeParkTycoonGame.Core;

namespace ThemeParkTycoonGame.Fancy.Controls
{
    /// <summary>
    /// Interaction logic for InventoryView.xaml
    /// </summary>
    public partial class InventoryView : UserControl
    {
        private Park park;
        public Park Park
        {
            get
            {
                return park;
            }
            set
            {
                park = value;
            }
        }

        public InventoryView()
        {
            InitializeComponent();
            ParkDetailsView parkDetails = new ParkDetailsView();
            park = parkDetails.Park;
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {

            RefreshInventory();

        }

        public void RefreshInventory()
        {
            InventoryList.Items.Clear();
            Marketplace marketplace = Marketplace.Instance;
            List<Ride> InventoryRides = marketplace.GetBuyableRides(Park.ParkInventory);
            int inventoryRidesCount = park.ParkInventory.Rides.Count();
            for (int i = 0; i < inventoryRidesCount; i++)
            {
                if (park.ParkInventory.Rides == null)
                {
                    return;
                }
                else
                {
                    InventoryList.Items.Add(park.ParkInventory.Rides[i].Name);
                    
                }

            }
        }


        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
