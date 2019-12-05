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
        public void addProductButton(object sender, EventArgs e)
        {
            product product = new product();

            product.Name = nameTextBox.Text;
        
            productData = product;
            this.Close();
        }

    }
}
