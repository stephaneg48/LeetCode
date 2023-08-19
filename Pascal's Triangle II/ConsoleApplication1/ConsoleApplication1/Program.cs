using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Solution
    {
        public static IList<int> GetRow(int rowIndex)
        {
            // use the same idea; already stores each row
            int numRows = rowIndex + 1;
            int[][] res = new int[numRows][];

            for (int i = 0; i < numRows; i++)
            {
                // set left & right edge respectively
                res[i] = new int[i + 1];
                res[i][0] = res[i][i] = 1;

                for (int j = 1; j < i; j++)
                    res[i][j] = res[i - 1][j - 1] + res[i - 1][j];
            }

            return res[numRows-1];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<int> result = Solution.GetRow(3);
            foreach (var num in result)
                Console.Write(num + " ");
            Console.WriteLine("\n");
        }
    }
}
