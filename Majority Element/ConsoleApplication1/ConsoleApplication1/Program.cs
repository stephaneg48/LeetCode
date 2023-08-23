using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Solution
    {
        public static int MajorityElement(int[] nums)
        {
            Dictionary<int, int> counters = new Dictionary<int, int>();
            int res = 0;

            foreach (int num in nums)
                if (counters.ContainsKey(num))
                    counters[num]++;
                else
                    counters[num] = 1;

            foreach (int key in counters.Keys)
                if (counters[key] > (int)Math.Floor((double)nums.Length / 2))
                    res = key;

            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
            int result = Solution.MajorityElement(nums);
            Console.WriteLine(result);
        }
    }
}
