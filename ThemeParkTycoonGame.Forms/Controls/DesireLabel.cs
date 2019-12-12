using System.Windows.Forms;
using ThemeParkTycoonGame.Core;

namespace ThemeParkTycoonGame.Forms.Controls
{
    public partial class DesireLabel : UserControl
    {
        private Desire desire;

        public DesireLabel()
        {
            InitializeComponent();
        }

        public DesireLabel(Desire desire)
            :this()
        {
            this.desire = desire;

            label.Text = string.Format("{0} - {1}", desire.GainedAt, desire.Reason);
        }
    }
}
