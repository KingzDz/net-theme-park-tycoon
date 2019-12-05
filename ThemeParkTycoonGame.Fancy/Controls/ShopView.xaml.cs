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
    /// Interaction logic for ShopView.xaml
    /// </summary>
    public partial class ShopView : UserControl
    {

        public ShopView()
        {
            InitializeComponent();
            
            foreach (ProductView product in Products.All)
            {
                ProductList.Children.Add(new Label()
                {
                    Content = product.Name
                });

            }

        }

        private void CreateProductButton_Click(object sender, RoutedEventArgs e)
        {
            product product = new product();
            product.Show();
            
        }
    }
}
