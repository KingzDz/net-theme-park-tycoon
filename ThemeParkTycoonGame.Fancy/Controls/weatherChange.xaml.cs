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
            string[] weathers = { "rain", "storm", "sun" };
            Random rand = new Random();
            int index = rand.Next(weathers.Length);

            MessageBox.Show(weathers[index]);
        }
    }
}
