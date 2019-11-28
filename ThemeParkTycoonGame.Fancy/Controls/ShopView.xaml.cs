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

namespace ThemeParkTycoonGame.Fancy.Controls
{
    /// <summary>
    /// Interaction logic for ShopView.xaml
    /// </summary>
    public partial class ShopView : UserControl
    {
        public ShopView()
        {
            InitializeComponent();

            List<string> shops = new List<string>();
            shops.Add("test");
            shops.Add("test2");
            shops.Add("test3");
            shops.Add("test4");
            shops.Add("test5");
        }

        private void CreateProductButton_Click(object sender, RoutedEventArgs e)
        {
            product product = new product();
            product.Show();
        }
    }
}
