using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Daily_212_Easy_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Join(" ", args);
            Regex regex = new Regex("(?i)[b-df-hj-np-tv-xz]");
            Console.WriteLine(regex.Replace(input, new MatchEvaluator(Robberify)));
        }

        static string Robberify(Match m) {
            return m.Value + "o" + m.Value.ToLower();
        }
    }
}
