using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThemeParkTycoonGame.Core;

namespace ThemeParkTycoonGame.Forms.Screens
{
    public partial class MarketplaceForm : Form, IPositionSelf
    {
        private Park park;

        public MarketplaceForm(Park park)
        {
            InitializeComponent();

            this.park = park;

            RefreshRides();
        }

        void IPositionSelf.LoadPosition(int maxX, int maxY)
        {
            this.Left = (int) (maxX * .5);
            this.Top = 0;
        }

        bool IPositionSelf.PositionChallenged(int maxX, int maxY, Form challengingForm)
        {
            throw new NotImplementedException();
        }

        private void RefreshRides()
        {
            Marketplace marketplace = Marketplace.Instance;
            List<Ride> buyableRides = marketplace.GetBuyableRides(park.ParkInventory);

            ridesListView.Items.Clear();

            // Prepare a list to add all the images to for rides.
            ridesListView.LargeImageList = new ImageList();
            ridesListView.LargeImageList.ImageSize = new Size(64, 64);

            for (int i = 0; i < buyableRides.Count; i++)
            {
                Ride ride = buyableRides[i];

                ridesListView.LargeImageList.Images.Add((Image) ride.Image);

                ListViewItem rideListViewItem = new ListViewItem();
                rideListViewItem.Group = ridesListView.Groups[0];
                rideListViewItem.Text = string.Format("{0}\r\n(${1})", ride.Name, ride.Cost);
                // Reference the image by it's index (weird that Microsoft designed it this way)
                rideListViewItem.ImageIndex = i;
                rideListViewItem.Tag = ride;

                ridesListView.Items.Add(rideListViewItem);
            }
        }

        // Called when double clicked (check out the Activation property, it's set to TwoClick)
        private void ridesListView_ItemActivate(object sender, EventArgs e)
        {
            if (ridesListView.SelectedItems.Count > 0)
            {
                Marketplace marketplace = Marketplace.Instance;
                ListViewItem selectedRideItem = ridesListView.SelectedItems[0];

                // Cast the Tag (object) back to Ride (we know there's a Ride in there)
                Ride ride = selectedRideItem.Tag as Ride;

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
            }
        }
    }
}
