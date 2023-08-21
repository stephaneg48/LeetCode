using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Solution
    {
        public static int RangeBitwiseAnd(int left, int right)
        {
            /*
            if (left == right) // base case
                return left;

            // first step: left & left + 1
            // in-between steps: result & left + 1
            // final step: result & right

            int res = left & (left + 1);
            int counter = left + 1;

            while (counter != right)
            {
                res = res & counter;
                counter++;
            }

            res = res & right;
        
            return res;
            */

            // above is a brute force solution
            // close, but only so much: 8257 / 8269 testcases passed
            // time limit...

            // right shift both numbers until they're 0...
            // when done, the # of iterations is the factor that they differ by
            // then left shift the left side of the range by that factor

            if (left == right) // base case
                return left;

            int res = 0, counter = 0;

            while (left != right)
            {
                counter += 1;
                left >>= 1;
                right >>= 1;
            }

            res = left << counter;
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int left = 5, right = 7;
            int result = Solution.RangeBitwiseAnd(left, right);
            Console.WriteLine(result);
        }
    }
}
