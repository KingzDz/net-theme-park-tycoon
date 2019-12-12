using Microsoft.Win32;
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
using ThemeParkTycoonGame.Core;

namespace ThemeParkTycoonGame.Fancy.Controls
{
    /// <summary>
    /// Interaction logic for product.xaml
    /// </summary>
    public partial class product : Window
    {
        public product productData;

        public product()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddnewProductButton_Click_1(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
             product.Name = nameTextBox.Text;
            double productPrice = double.Parse(priceTextBox.Text);
            product.Price = productPrice;
             

            Products.All.Add(product);

            MessageBox.Show(product.Name);
            this.Close();
        }

        private void priceHigherButton_Click(object sender, RoutedEventArgs e)
        {
            string price = priceTextBox.Text;
            int priceup = int.Parse(price);
            int newprice;
            newprice = priceup + 1;
           priceTextBox.Text = newprice.ToString();
        }

        private void priceLowerButton_Click(object sender, RoutedEventArgs e)
        {
            string price = priceTextBox.Text;
            int pricedown = int.Parse(price);
            if (pricedown != 0)
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

        private void iconpicture_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported images|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
        }
    }
}
