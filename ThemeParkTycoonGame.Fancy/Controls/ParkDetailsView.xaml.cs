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
    /// Interaction logic for ParkControl.xaml
    /// </summary>
    public partial class ParkDetailsView : UserControl
    {
        private Park park;
        public Park Park
        {
            get
            {
                return park;
            }
            set
            {
                park = value;

                // Using binding, we don't need all this like in WinForms:
                //RefreshBalance(park.ParkWallet.Balance);
                //RefreshInventory(park.ParkInventory);

                //park.ParkWallet.BalanceChanged += Wallet_BalanceChanged;
                //park.ParkInventory.InventoryChanged += Inventory_Changed;
            }
        }

        public ParkDetailsView()
        {
            InitializeComponent();

            this.DataContext = this;

        }
    }
}