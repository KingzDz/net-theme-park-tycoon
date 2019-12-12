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
using System.Windows.Shapes;

namespace ThemeParkTycoonGame.Fancy.Controls
{
    /// <summary>
    /// Interaction logic for weatherChange.xaml
    /// </summary>
    public partial class weatherChange : Window
    {
        public weatherChange()
        {
            InitializeComponent();
        }

        private void WeatherChangeButton_Click(object sender, RoutedEventArgs e)
        {
            ThemeParkTycoonGame.Core.Weather.GetRandom();

            //MessageBox.Show(Core.Weather.GetRandom().Name);
            if (Core.Weather.GetRandom().Name == "Sunny")
            {
                imagePictureBox.Tag = "/Resources/weather.sun_48.png";
                imagePictureBox.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/weather_sun_48.png"));

            }
            else if (Core.Weather.GetRandom().Name == "Rainy")
            {
                imagePictureBox.Tag = "/Resources/weather.rain_48.png";
                imagePictureBox.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/weather_rain_48.png"));

            }
            else if (Core.Weather.GetRandom().Name == "Stormy")
            {
                imagePictureBox.Tag = "/Resources/weather.storm_48.png";
                imagePictureBox.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/weather_storm_48.png"));

            }
            else if (Core.Weather.GetRandom().Name == "Snow")
            {
                imagePictureBox.Tag = "/Resources/weather.snow_48.png";
                imagePictureBox.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/weather_snow_48.png"));

            }
        }
    }
}
