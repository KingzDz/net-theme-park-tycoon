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
    /// Interaction logic for ShopsView.xaml
    /// </summary>
    public partial class ShopsView : Window
    {
        public Item(List<item> items)
        {
            InitializeComponent();

        }
        private void addProductConfirmButton_Click(object sender, EventArgs e)
        {
            item = new item();

            item.Name = itemNameTextBox.Text;
            item.Description = itemDescriptionTextBox.Text;
            item.Price = itemPriceTextBox.Text;

            itemData = item;
            this.Close();
        }
    }
}

