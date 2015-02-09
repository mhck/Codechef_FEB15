using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechef_FEB15
{

    /**
     * Chef had a hard day and want to play little bit. The game is called "Chain". Chef has the sequence of symbols. Each symbol is either '-' or '+'. The sequence is called Chain if each two neighboring symbols of sequence are either '-+' or '+-'.
     * For example sequence '-+-+-+' is a Chain but sequence '-+-+--+' is not.
     * Help Chef to calculate the minimum number of symbols he need to replace (ex. '-' to '+' or '+' to '-') to receive a Chain sequence.
     * Input
     * 
     * First line contains single integer T denoting the number of test cases.
     * Line of each test case contains the string S consisting of symbols '-' and '+'. 
     * 
     **/
    class Program
    {
        private const string PLUS = "+";
        private const string MINUS = "-";

        private static string current = "";
        private static int[] replacements;

        static void Main(string[] args)
        {
            int t = Int32.Parse(Console.ReadLine());
            replacements = new int[t];
            for (int i = 0; i < t; i++)
            {
                string s = Console.ReadLine();
                if (s.Length <= 0) continue;
                string first = s.Substring(i, 1);
                if (first.Equals(PLUS))
                    current = PLUS;
                else if (first.Equals(MINUS))
                    current = MINUS;
                for (int j = 1; j < s.Length; j++)
                {
                    current = NextInput();
                    if (!s.Substring(j, 1).Equals(current))
                    {
                        replacements[i] += 1;
                    }
                    if (s.Substring(s.Length - 1).Equals(s.Substring(0, 1)))
                    {
                        replacements[i] += 1;
                    }
                }
                if (s.Length == 1 && (s.Substring(0, 1).Equals(PLUS) || s.Substring(0, 1).Equals(MINUS)))
                    replacements[i] += 1;
            }

            foreach (int rep in replacements)
            {
                Console.WriteLine(rep);
            }
        }

        public static string NextInput()
        {
            return current == PLUS ? MINUS : PLUS;
        }
    }
}
