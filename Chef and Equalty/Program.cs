using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef_and_Equalty
{

    /**
     * 
     * Input
     * The first line of the input contains an integer T denoting the number of test cases.
     * The first line of each test case contains a single integer N denoting the number of piles.
     * The second line contains N space-separated integers A1, A2, ..., AN denoting the number of coins in each pile.
     * Output
     * For each test case, output a single line containing an integer corresponding to the minimum number of operations assistant needs to do.
     * */
    class Program
    {
        static void Main(string[] args)
        {
            
            int cases = Int32.Parse(Console.ReadLine());
            int[][] pileNumbers = new int[cases][];
            for (int i = 0; i < cases; i++)
            {
                int piles = Int32.Parse(Console.ReadLine());
                for (int j = 0; j < piles; j++)
                {
                    string pile = Console.ReadLine();
                    string[] pileArray = pile.Split(',');
                    pileNumbers[j] = Array.ConvertAll(pileArray, n => Int32.Parse(n));
                }
            }
        }
    }
}
