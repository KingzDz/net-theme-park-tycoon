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
    public partial class WeatherForm : Form, IPositionSelf
    {
        private Park park;

        public WeatherForm(Park park)
        {
            InitializeComponent();

            this.park = park;

            this.park.WeatherChanged += Park_WeatherChanged;

            RefreshWeather(park.CurrentWeather);
        }

        private void Park_WeatherChanged(object sender, WeatherChangedEventArgs e)
        {
            RefreshWeather(e.Weather);
        }
        
        private void RefreshWeather(Weather weather)
        {
            weatherLabel.Text = weather.Name;
            weatherPictureBox.Image = (Image) weather.Image;

            weatherLabel.Location = new Point((int)(weatherPictureBox.Location.X + (weatherPictureBox.Size.Width * .5) - (weatherLabel.Size.Width * .5)), weatherLabel.Location.Y);
        }

        void IPositionSelf.LoadPosition(int maxX, int maxY)
        {
            this.Left = (int)(maxX * .5);
            this.Top = maxY;
        }

        bool IPositionSelf.PositionChallenged(int maxX, int maxY, Form challengingForm)
        {
            throw new NotImplementedException();
        }
    }
}
