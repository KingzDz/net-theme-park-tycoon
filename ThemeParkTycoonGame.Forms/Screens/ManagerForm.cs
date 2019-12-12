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
    public partial class ManagerForm : Form
    {
        const string PREFIX = "Theme Park Tycoon - ";

        private Park park;

        public ManagerForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            park = new Park();

            // Hook to the park namechange to update the titlebar
            park.NameChanging += Park_NameChanging;

            // Change the park name to be something fun for the user
            park.Name = "Loopy Landscapes";
        }

        public MdiClient GetMdiClientWindow()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient) return ctl as MdiClient;
            }
            return null;
        }

        private void ShowForm(Form form)
        {
            // Make this form a child of this ManagerForm (it will appear inside it, like with Paint.NET or old Windows software)
            form.MdiParent = this;
            form.Show();

            if (form is IPositionSelf)
            {
                int maxX = Screen.PrimaryScreen.Bounds.Width;
                int maxY = Screen.PrimaryScreen.Bounds.Height;

                if (this.IsMdiContainer)
                {
                    MdiClient client = GetMdiClientWindow();
                    maxX = client.Bounds.Width;
                    maxY = client.Bounds.Height;
                }

                // Subtract our size from the max
                maxX -= form.Bounds.Width;
                maxY -= form.Bounds.Height;

                // Move a bit more from the edge to hide the scrollbars
                maxX -= 5;
                maxY -= 5;

                (form as IPositionSelf).LoadPosition(maxX, maxY);
            }
        }

        private void Park_NameChanging(object sender, NameChangingEventArgs e)
        {
            this.Text = PREFIX + e.ParkName;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // When the manager form loads, open the following screens by default:
            parkConfigurationToolStripButton.PerformClick(); // pretend to click on the park button.
            buyRideToolStripButton.PerformClick();
            guestsToolStripButton.PerformClick();
            weatherToolStripButton.PerformClick();
            debugToolStripButton.PerformClick();
        }

        /*
         * TODO: Make sure the forms can only open once
         */

        private void guestsToolStripButton_Click(object sender, EventArgs e)
        {
            ShowForm(new GuestsForm(park));
        }

        private void parkConfigurationToolStripButton_Click(object sender, EventArgs e)
        {
            ShowForm(new ParkConfigurationForm(park));
        }

        private void debugToolStripButton_Click(object sender, EventArgs e)
        {
            ShowForm(new DebugForm(park));
        }

        private void weatherToolStripButton_Click(object sender, EventArgs e)
        {
            ShowForm(new WeatherForm(park));
        }

        private void buyRideToolStripButton_Click(object sender, EventArgs e)
        {
            ShowForm(new MarketplaceForm(park));
        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            this.park.GuestController.DoTick(tickTimer.Interval);
        }
    }
}
