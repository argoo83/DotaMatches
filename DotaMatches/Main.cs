using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Net;
using DotaMatches.Data;
using System.Web.Script.Serialization;
using DotaMatches.Match;
using DotaMatches.Controls;

namespace DotaMatches
{
    public partial class Main : MetroForm
    {
        private List<UpComingMatch> upComingMatches;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string json = wc.DownloadString("http://api.mpevelerapi.com/gg/matches/v120/");
            

            MatchParser matches = new MatchParser();

            JavaScriptSerializer jss = new JavaScriptSerializer();
            matches = jss.Deserialize<MatchParser>(json);

            upComingMatches = matches.GetUpComingMatches().ToList();

            

            foreach (UpComingMatch u in upComingMatches)
            {
                ucUpComingMatch ucUp = new ucUpComingMatch();
                ucUp.Team1 = u.Team1;
                ucUp.Team2 = u.Team2;
                ucUp.TimeLeft = u.TimeLeft;

                flowUpcomingMatches.Controls.Add(ucUp);
            }

        }
    }
}
