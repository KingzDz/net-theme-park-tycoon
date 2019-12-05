using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using ThemeParkTycoonGame.Fancy.Controls;

namespace ThemeParkTycoonGame.Fancy.Controls
{
    /// <summary>
    /// Interaction logic for DebugView.xaml
    /// </summary>
    public partial class DebugView : UserControl
    {
        public GuestController GuestController;
        public GuestList Guests;
        public DebugGuestView debugGuestView;
        public Park Park;

        
        public DebugView()
        {
            InitializeComponent();
            
            debugGuestView = new DebugGuestView();
            controlParent.Children.Add(debugGuestView);
            
            controlParent.Visibility = Visibility.Hidden;
            debugGuestView.debugView = this;
           
        }
    

        private void EditGuestButton_Click(object sender, RoutedEventArgs e)
        {
            if(Guests.Guests.Count>0)
            {
           
               try
                {

                    
                    debugGuestView.guestsListView.Items.Refresh();
                }
                catch
                {
                    MessageBox.Show("Pick a guest, please");
                }
              
                controlParent.Visibility = Visibility.Visible;
               
            }
        }

        private void AddNewGuestButton_Click(object sender, RoutedEventArgs e)
        {
            Guest guest = new Guest();

            Guests.Guests.Add(guest); // Add created guest to guest list

            // Show message box
            string message = "There has been added a guest succesfully!";
            string title = "Add New Guest";

            MessageBox.Show(message, title);
        }
        
        private void changeWeatherButton_Click(object sender, RoutedEventArgs e)
        {
            weatherChange weather = new weatherChange();
            weather.Show();
        }

        private void RefreshGuestListButton_Click(object sender, RoutedEventArgs e)
        {
            debugGuestView.guestsListView.Items.Clear();
            for (int i = 0; i < Guests.Count(); i++)
            {
                debugGuestView.guestsListView.Items.Add(Guests.Guests[i]);
                debugGuestView.guestsListView.Items.Refresh();
                //guests.Guests[0].Name = "Fucker";
            }
            debugGuestView.guestsListView.Items.Refresh();
        }

        private void AddMoneyButton_Click(object sender, RoutedEventArgs e)
        {
            this.park.ParkWallet.SubtractFromBalance(-10000, "A mysterious being gave the park money.");
        }

        private void AddThousandButton_Click(object sender, RoutedEventArgs e)
        {
            
            this.Park.ParkWallet.SubtractFromBalance(-1000, "A mysterious being gave the park money.");
            MessageBox.Show("Your balance is now: " + Park.ParkWallet.balance.ToString());
        }
    }
}
