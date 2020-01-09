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
    public partial class ParkConfigurationForm : Form, IPositionSelf
    {
        private Park park;

        public ParkConfigurationForm(Park park)
        {
            InitializeComponent();

            this.park = park;

            RefreshBalance(park.ParkWallet.Balance);
            RefreshInventory(park.ParkInventory);

            park.ParkWallet.BalanceChanged += ParkWallet_BalanceChanged;
            park.ParkInventory.InventoryChanged += ParkInventory_Changed;
        }

        private void RefreshInventory(ParkInventory parkInventory)
        {
            List<BuildableObject> objects = parkInventory.All;

            objectsListView.LargeImageList = new ImageList();
            objectsListView.LargeImageList.ImageSize = new Size(64, 64);
            objectsListView.Items.Clear();

            for (int i = 0; i < objects.Count; i++)
            {
                BuildableObject ride = objects[i];

                objectsListView.LargeImageList.Images.Add((Image) ride.Image);

                ListViewItem rideListViewItem = new ListViewItem();
                rideListViewItem.Group = objectsListView.Groups[0];
                rideListViewItem.Text = string.Format("{0}\r\n(${1})", ride.Name, ride.Cost);
                rideListViewItem.ImageIndex = i;
                rideListViewItem.Tag = ride;

                objectsListView.Items.Add(rideListViewItem);
            }
        }

        private void ParkWallet_BalanceChanged(object sender, BalanceChangedEventArgs e)
        {
            RefreshBalance(e.Balance);
        }

        private void ParkInventory_Changed(object sender, InventoryChangedEventArgs e)
        {
            RefreshInventory((ParkInventory) e.Inventory);
        }

        private void RefreshBalance(decimal balance)
        {
            balanceTextBox.Text = balance.ToString("N2");
        }

        private void entryFeeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.park.EntryFee = entryFeeNumericUpDown.Value;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.park.DoNameChange(nameTextBox.Text);
        }

        private void ParkConfigurationForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = park.Name;
        }

        void IPositionSelf.LoadPosition(int maxX, int maxY)
        {
            this.Left = 0;
            this.Top = 0;
        }

        bool IPositionSelf.PositionChallenged(int maxX, int maxY, Form challengingForm)
        {
            throw new NotImplementedException();
        }

        private void objectsListView_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem selectedObjectItem = objectsListView.SelectedItems[0];

            // Cast the Tag (object) back to Ride (we know there's a Ride in there)
            // TODO: Support shops as well
            Ride ride = selectedObjectItem.Tag as Ride;

            // Open ride window to allow changing entry fee, name and see riders/waiting time.
        }

        private void balanceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
