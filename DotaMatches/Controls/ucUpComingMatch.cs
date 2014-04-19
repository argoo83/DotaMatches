using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotaMatches.Controls
{
    public partial class ucUpComingMatch : UserControl
    {
        public string Team1 { get { return lblTeam1.Text; } set { lblTeam1.Text = value; } }
        public string Team2 { get { return lblTeam2.Text; } set { lblTeam2.Text = value; } }
        public string TimeLeft { get { return lblTime.Text; } set { lblTime.Text = value; } }

        public ucUpComingMatch()
        {
            InitializeComponent();
        }
    }
}
