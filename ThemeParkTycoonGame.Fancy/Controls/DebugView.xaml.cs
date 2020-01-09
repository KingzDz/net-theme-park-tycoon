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
using ThemeParkTycoonGame.Fancy.Windows;

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
                if (Application.Current.MainWindow.Height < 600)
                {
                    Application.Current.MainWindow.Height = 660;
                }


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
            Console.WriteLine("Now changing weather.");
            Park.DoChangeWeather();
            Console.WriteLine("Weather: " + Park.CurrentWeather.Name);
            //weatherChange weather = new weatherChange();
            //weather.Show();
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
            this.Park.ParkWallet.SubtractFromBalance(-10000, "A mysterious being gave the park money.");
            MessageBox.Show("your balance is now: " + Park.ParkWallet.balance.ToString());
        }

        private void AddThousandButton_Click(object sender, RoutedEventArgs e)
        {
            
            this.Park.ParkWallet.SubtractFromBalance(-1000, "A mysterious being gave the park money.");
            MessageBox.Show("Your balance is now: " + Park.ParkWallet.balance.ToString());
        }

        double height = 0;

        public MainWindow ParentWindow { get; set; }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (FrameworkElement item in buttonHolder.Children)
            {


                if (item.Height > 0)
                {
                    height += item.Height;
                }
            }

            ParentWindow.Height = height;
        }
    }
}
