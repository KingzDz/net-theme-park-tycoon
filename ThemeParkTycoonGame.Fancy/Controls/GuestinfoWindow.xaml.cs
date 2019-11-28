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
using System.Windows.Shapes;
using ThemeParkTycoonGame.Core;

namespace ThemeParkTycoonGame.Fancy.Controls
{
    /// <summary>
    /// Interaction logic for GuestinfoWindow.xaml
    /// </summary>
    public partial class GuestinfoWindow : Window
    {
        Core.Guest guest;
        public GuestinfoWindow(Core.Guest selectedGuest)
        {
            InitializeComponent();

            this.guest = selectedGuest;

            //RefreshStats();
        }
        private void RefreshStats()
        {
            wantingRideSlider.Value = RandomPercentage();
            excitementSlider.Value = RandomPercentage();
            hungerSlider.Value = RandomPercentage();
            thirstSlider.Value = RandomPercentage();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Title = guest.Name;
        }

        //private void RefreshFinances()
        //{
        //    // clear the panel
        //    financialHistory.Items.Clear();

        //    foreach (TransactionLog log in this.guest.Wallet.History)
        //    {

        //        ListViewItem temp = new ListViewItem();

        //        financialHistory.Items.Add(temp);


        //        //new string[] {
        //        //    (-log.Amount).ToString(),
        //        //    log.Time.ToString(),
        //        //    log.Reason,
        //        //}));
        //    }
        //}

        private double RandomPercentage()
        {
            Random random = new Random();
            double decimalNumber = (double) random.Next(0, 10);
            

            return decimalNumber;
        }
    }
}
