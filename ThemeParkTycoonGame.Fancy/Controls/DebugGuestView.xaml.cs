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
    /// Interaction logic for DebugGuestView.xaml
    /// </summary>
    public partial class DebugGuestView : UserControl
    {
        public string guestName;
        public DebugView debugView;

        public DebugGuestView()
        {
            
            InitializeComponent();
            GuestStatLabel.Content = guestName;
        }

        private void ChangeNameButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                guestName = GuestNameTextBox.Text;
                GuestStatLabel.Content = guestName;
                debugView.guests.Guests[guestsListView.SelectedIndex].Name = guestName;



            }
            catch
            {
                
                MessageBox.Show("Invalid Input Detected");
            }
        }
    }
}
