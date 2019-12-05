using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThemeParkTycoonGame.Core;

namespace ThemeParkTycoonGame.Forms.Controls
{
    public partial class StatSlider : UserControl
    {
        private Stat stat;

        public StatSlider()
        {
            InitializeComponent();
        }

        public StatSlider(Stat stat)
            :this()
        {
            this.stat = stat;

            statLabel.Text = stat.Type.Name;
            statValueInput.Value = (decimal) stat.Value;
        }

        private void statValueInput_ValueChanged(object sender, EventArgs e)
        {
            this.stat.Value = (float) statValueInput.Value;
        }
    }
}
