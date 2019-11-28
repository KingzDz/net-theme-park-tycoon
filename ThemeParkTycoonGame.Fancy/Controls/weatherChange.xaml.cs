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
            string[] rain = { "rain", "/Resources/weather_rain_48.png" };
            string[] storm = { "storm", "/Resources/weather_storm_48.png" };
            string[] snow = { "snow", "/Resources/weather_snow_48.png" };
            string[] sun = { "sun", "Resources/weather_sun_48.png" };
            string[] weathers = { rain[0], storm[0], sun[0], snow[0] };

            Random rand = new Random();
            int index = rand.Next(weathers.Length);

            MessageBox.Show(weathers[index]);
        }
    }
}
