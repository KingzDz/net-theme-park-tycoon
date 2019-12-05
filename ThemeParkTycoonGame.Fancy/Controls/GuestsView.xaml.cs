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
    /// Interaction logic for ParkControl.xaml
    /// </summary>
    public partial class GuestsView : UserControl
    {
        private GuestList guests;
        public GuestList Guests
        {
            get
            {
                return guests;
            }
            set
            {
                guests = value;

                guests.GuestAdded += Guests_GuestAdded;
                guests.GuestRemoved += Guests_GuestRemoved;
            }
        }

        public GuestsView()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        private void Guests_GuestAdded(object sender, GuestAddedEventArgs e)
        {
            guestsListView.Items.Refresh();
        }

        private void Guests_GuestRemoved(object sender, GuestRemovedEventArgs e)
        {
            guestsListView.Items.Refresh();
        }
    }
}
