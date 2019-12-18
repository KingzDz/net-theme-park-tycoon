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
            RefreshProductList();

        }
        public Product product;

        public string selectedProduct { get; set; }

        public void RefreshProductList()
        {
            productListbox.Items.Clear();

            foreach (Product product in Products.All)
                {

                    productListbox.Items.Add(product.Name + "     " + product.Price);

                }
            
        }
            private void CreateProductButton_Click(object sender, RoutedEventArgs e)
            {
                product product = new product();
                product.ShowDialog();
                RefreshProductList();

        }

        private void editProductButton_Click(object sender, RoutedEventArgs e)
        {

            

            Product product = new Product();
            product.Name = nameTextBox.Text;
            double productPrice = double.Parse(priceTextBox.Text);
            product.Price = productPrice;

            productListbox.Items.RemoveAt(productListbox.Items.IndexOf(productListbox.SelectedItem));


            productListbox.Items.Add(product);
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string price = priceTextBox.Text;
            int priceup = int.Parse(price);
            int newprice = priceup + 1;
            priceTextBox.Text = newprice.ToString();

        }

        private void priceDownButton_Click(object sender, RoutedEventArgs e)
        {
            string price = priceTextBox.Text;
            int pricedown = int.Parse(price);
            if (pricedown < 0)
            {
                int newprice;
                newprice = pricedown - 1;
                priceTextBox.Text = newprice.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter a value greater than Zero");
            }
        }
    }
}
