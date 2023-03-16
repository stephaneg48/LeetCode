namespace Monotonic_Array
{
    public class Solution
    {
        public static bool IsMonotonic(int[] nums)
        {
            if (nums.Length == 1)
                return true;

            bool res = false;
            for (int i = 0; i < nums.Length; i++) // increasing
            {
                if (i == 0)
                    continue;
                else
                {
                    if (nums[i] >= nums[i - 1])
                        res = true;
                    else
                    {
                        res = false; 
                        break;
                    }
                }
            }

            if (res)
                return res;
            else
            {
                for (int i = 0; i < nums.Length; i++) // decreasing
                {
                    if (i == 0)
                        continue;
                    else
                    {
                        if (nums[i] <= nums[i - 1])
                            res = true;
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            return res;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 6, 5, 4, 4 };
            bool res = Solution.IsMonotonic(nums);
            Console.WriteLine(res);
        }
    }
}