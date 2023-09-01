using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Solution
    {
        public static int SingleNonDuplicate(int[] nums)
        {
            // sounds like binary search, just based on time complexity
            // the unique element to look for will not have an identical neighbor

            int left = 0, right = nums.Length - 1;
            int res = Solution.BS(nums, left, right);
            return res;

        }

        public static int BS(int[] nums, int L, int R)
        {
            if (L > R)
                return -1;

            double mid = (L + R) / 2;
            var middle = (int)Math.Floor(mid);

            // original BS algorithm won't work because key is unknown
            // need to factor in the edges of the entire array...
            // if the edges from recursive call are used, value will be lost

            bool front = true, back = true;

            
            if (middle == 0 || middle > 0 && (nums[middle - 1] != nums[middle]))
                front = false;
            if (middle == nums.Length - 1 || middle < nums.Length - 1 && (nums[middle] != nums[middle + 1]))
                back  = false;

            if (!front && !back)
                return nums[middle];
            var temp = Solution.BS(nums, L, middle - 1);
            if (temp == -1)
                temp = Solution.BS(nums, middle + 1, R);
            return temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2, 3, 3, 4, 4, 8, 8 };
            int result = Solution.SingleNonDuplicate(nums);
            Console.WriteLine(result);
        }
    }
}
