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
    public partial class MarketControl : UserControl
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
        public MarketControl()
        {
            InitializeComponent();
        }

        private void MarketButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshRides();
        }

        private void RefreshRides()
        {
            Marketplace marketplace = Marketplace.Instance;
            List<Ride> buyableRides = marketplace.GetBuyableRides(park.ParkInventory);
            Testblock1.Text = buyableRides[0].Name;
        }
    }
}
