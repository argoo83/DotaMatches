using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaMatches.Match
{
    public abstract class Match
    {
        private string team1;

        public string Team1
        {
            get { return team1; }
            set { team1 = value; }
        }
        private string team2;

        public string Team2
        {
            get { return team2; }
            set { team2 = value; }
        }

        private string dotaEvent;

        public string Event
        {
            get { return dotaEvent; }
            set { dotaEvent = value; }
        }

        public Match()
        {

        }


    }
}
