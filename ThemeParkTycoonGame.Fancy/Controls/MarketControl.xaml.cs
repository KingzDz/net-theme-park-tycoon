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
        private Ride ride;
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
            ParkDetailsView parkDetails = new ParkDetailsView();
            park = parkDetails.Park;
        }

        private void RefreshRides()
        {
            ShopList.Items.Clear();
            Marketplace marketplace = Marketplace.Instance;
            List<Ride> buyableRides = marketplace.GetBuyableRides(park.ParkInventory);
            int buyableRidesCount = buyableRides.Count();
            for (int i = 0; i < buyableRidesCount; i++)
            {
                ShopList.Items.Add(buyableRides[i]);
                //ShopList.Items.Add(new DirectoryListing()
                //{
                //    Name = buyableRides[i].Name,
                //    Path = buyableRides[i].Image.ToString()

                //});
                //ShopList.Items.Add(buyableRides[i].Name + buyableRides[i].Image);
            }

            BuyButton.Visibility = Visibility.Collapsed;
            NameLabel.Content = "";
            DurationLabel.Content = "";
            CostLabel.Content = "";
        }

        private void listView_Click(object sender, RoutedEventArgs e)
        {
            Marketplace marketplace = Marketplace.Instance;
            List<Ride> buyableRides = marketplace.GetBuyableRides(park.ParkInventory);

            var item = (sender as ListView).SelectedItem;
            if (item != null)
            {
                BuyButton.Visibility = Visibility.Visible;
                for (int i = 0; i < buyableRides.Count(); i++)
                {
                    if (item.ToString() == buyableRides[i].Name)
                    {
                        Ride ride = buyableRides[i] as Ride;

                        NameLabel.Content = "Name: " + buyableRides[i].Name;
                        DurationLabel.Content = "Duration: " + buyableRides[i].Duration;
                        CostLabel.Content = "Cost: " + buyableRides[i].Cost;

                    }
                }
            }
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshRides();
            RefreshBalance();
        }

        private void RefreshBalance()
        {
            balanceLabel.Content = "Balance: " + park.ParkWallet.Balance.ToString();
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            Marketplace marketplace = Marketplace.Instance;
            List<Ride> buyableRides = marketplace.GetBuyableRides(park.ParkInventory);

            var item = ShopList.SelectedItem;
            if (item != null)
            {
                for (int i = 0; i < buyableRides.Count(); i++)
                {
                    if (item.ToString() == buyableRides[i].Name)
                    {
                        Ride ride = buyableRides[i] as Ride;
                        if (park.ParkWallet.Balance < ride.Cost)
                        {
                            MessageBox.Show(string.Format("You do not have enough money to buy {0}!", ride.Name));
                            return;
                        }

                        if (park.ParkInventory.Contains(ride))
                        {
                            MessageBox.Show(string.Format("You already own {0}!", ride.Name));
                            return;
                        }
                        marketplace.Buy(ride, park.ParkWallet, park.ParkInventory);
                        RefreshRides();
                        RefreshBalance();
                    }
                }
            }
        }

        private void DataTemplate_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
