using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaMatches.Match
{
    class UpComingMatch : Match
    {
        private string timeLeft;

        public string TimeLeft
        {
            get { return timeLeft; }
            set { timeLeft = value; }
        }

    }
}
