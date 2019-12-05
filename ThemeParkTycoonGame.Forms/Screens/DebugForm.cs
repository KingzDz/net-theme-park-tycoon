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
    public partial class DebugForm : Form, IPositionSelf
    {
        private Park park;

        public DebugForm(Park park)
        {
            InitializeComponent();

            this.park = park;
        }

        private void addGuestButton_Click(object sender, EventArgs e)
        {
            var guest = new Guest();
            guest.Wallet.SubtractFromBalance(-this.park.EntryFee * 5, "Was spawned out of thin air with 5 times the entry fee to spend.");

            this.park.Guests.Add(guest);
        }

        private void changeWeatherButton_Click(object sender, EventArgs e)
        {
            this.park.DoChangeWeather();
        }

        private void generateMoneyButton_Click(object sender, EventArgs e)
        {
            this.park.ParkWallet.SubtractFromBalance(-1000, "A mysterious being gave the park money.");
        }
    
        // Should position this form. Occurs right after showing the form
        void IPositionSelf.LoadPosition(int maxX, int maxY)
        {
            this.Left = maxX;
            this.Top = maxY;
        }

        // Should position this form and return true (self moved). Or should return false (other form should move)
        bool IPositionSelf.PositionChallenged(int maxX, int maxY, Form challengingForm)
        {
            throw new NotImplementedException();
        }

        private void editGuestButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature to edit stats and name of a guest from the guest list not completed");
        }

        private void generateMoreMoneyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature to add 10,000 cash not completed");
        }

        private void moreButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature to do more than the above features is not done yet.");
        }
    }
}
