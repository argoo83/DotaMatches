using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaMatches.Match
{
    public class FinnishedMatch : Match
    {
        private string result;

        public string Result
        {
            get { return result; }
            set { result = value; }
        }

    }
}
