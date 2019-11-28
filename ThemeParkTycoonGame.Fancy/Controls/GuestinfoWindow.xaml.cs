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
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //balanceLabel.Content = guest.Wallet.Balance;
        }

        //private void RefreshFinances()
        //{
        //clear the panel
        //ListView.Items.Clear();

        //foreach (TransactionLog log in this.guest.Wallet.History)
        //{
        //guest.Wallet.Add()
        //FinancieHistory.Colums.Add(new ) new string[] {
        //(-log.Amount).ToString(),
        //log.Time.ToString(),
        //log.Reason,
        //}));
         //}
    }
}

