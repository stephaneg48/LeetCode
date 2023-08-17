using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Solution
    {
        /*
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> res = new List<IList<int>>();

            // no malloc in C#, so manually assign the space

            for (int i = 1; i <= numRows; i++)
            {
                res.Add(new List<int>(i));
            }

            // nothing in the lists yet, but they have their capacities.
            // so, assign the values

            for (int i = 0; i < numRows; i++)
                for (int j = 0; j <= i; j++)
                    res[i].Add(nCr(i, j));

            
            foreach (var list in res)
            {
                foreach(var num in list)
                    Console.Write(num + " ");
                Console.WriteLine("\n");
            }

                return res;
        }

        public static int fact(int thingsToChoose)
        {
            if (thingsToChoose == 0 || thingsToChoose == 1)
                return 1;
            else
                return (thingsToChoose * fact(thingsToChoose - 1));
        }

        public static int nCr(int n, int r) // combination
        {
            return fact(n) / (fact(r) * fact(n - r));
        }
        */

        // above doesn't work
        // even if long (or ulong) was used, factorial grows too fast
        // so the program will fall apart after n = 13 for ints, n = 20 for longs

        // outer edges of Pascal's triangle is always 1
        // lower num is sum of upper left & right nums
        // build it based on this instead...

        public static IList<IList<int>> Generate(int numRows)
        {
            int[][] res = new int[numRows][];

            for (int i = 0; i < numRows; i++)
            {
                // set left & right edge respectively
                res[i] = new int[i+1];
                res[i][0] = res[i][i] = 1; 

                for (int j = 1; j < i; j++)
                    res[i][j] = res[i-1][j-1] + res[i-1][j];
            }

            /*
            foreach (var list in res)
            {
                foreach (var num in list)
                    Console.Write(num + " ");
                Console.Write("\n");
            }
            */

            return res;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<IList<int>> result = Solution.Generate(14);
        }
    }
}
