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
using ThemeParkTycoonGame.Fancy.Controls;
namespace ThemeParkTycoonGame.Fancy.Controls
{
    /// <summary>
    /// Interaction logic for DebugView.xaml
    /// </summary>
    public partial class DebugView : UserControl
    {
        public GuestList guests;
        public DebugGuestView debugGuestView;
        
        public DebugView()
        {
            debugGuestView = new DebugGuestView();
            InitializeComponent();
        }

        private void EditGuestButton_Click(object sender, RoutedEventArgs e)
        {
            if(guests.Guests.Count>0)
            {

                debugGuestView.guestName = guests.Guests[0].Name;
                debugGuestView.InitializeComponent();
                debugGuestView.BringIntoView();
            }
        }
    }
}
