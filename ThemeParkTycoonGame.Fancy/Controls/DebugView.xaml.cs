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
using ThemeParkTycoonGame.Fancy;
namespace ThemeParkTycoonGame.Fancy.Controls
{
    /// <summary>
    /// Interaction logic for DebugView.xaml
    /// </summary>
    public partial class DebugView : UserControl
    {
        GuestsView guests;
        public DebugView()
        {
           
            InitializeComponent();
        }

        private void EditGuestButton_Click(object sender, RoutedEventArgs e)
        {
            if(guests.guestsListView.Items.Count > 0)
            {
                MessageBox.Show(guests.guestsListView.Items[0].ToString());
            }
        }
    }
}
