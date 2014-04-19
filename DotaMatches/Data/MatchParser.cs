using DotaMatches.Match;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DotaMatches.Data
{
    class MatchParser
    {
        public List<string> eventLive { get; set; }
        public List<string> eventSoon { get; set; }
        public List<string> eventDone { get; set; }


        public IEnumerable<LiveMatch> GetLiveMatches()
        {
            return null;
        }
        public IEnumerable<UpComingMatch> GetUpComingMatches()
        {
            foreach (string s in eventSoon)
            {
                UpComingMatch u = new UpComingMatch();
                List<string> teams = GetSubStrings(s, "height='9px'>", "</td>").ToList();
                List<string> timeLeft = GetSubStrings(s, "gg_date'>", "</td>").ToList();

                u.Team1 = teams[0];
                u.Team2 = teams[1];
                u.TimeLeft = timeLeft[0];

                yield return u;
            }

        }
        private IEnumerable<string> GetSubStrings(string input, string start, string end)
        {
            Regex r = new Regex(Regex.Escape(start) + "(.*?)" + Regex.Escape(end));
            MatchCollection matches = r.Matches(input);
            foreach (System.Text.RegularExpressions.Match match in matches)
                yield return match.Groups[1].Value;
        }
    }

    
}
