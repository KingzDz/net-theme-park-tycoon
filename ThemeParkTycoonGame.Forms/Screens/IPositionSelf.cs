using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemeParkTycoonGame.Forms.Screens
{
    internal interface IPositionSelf
    {
        void LoadPosition(int maxX, int maxY);
        bool PositionChallenged(int maxX, int maxY, Form challengingForm);
    }
}
