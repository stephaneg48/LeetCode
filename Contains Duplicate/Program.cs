namespace Contains_Duplicate
{
    public class Solution
    {
        public static bool ContainsDuplicate(int[] nums) 
        {
            // use hashmap
            Dictionary<int, int> counters = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (counters.ContainsKey(num))
                {
                    counters[num]++;
                    if (counters[num] > 1)
                        return true;
                }
                else
                    counters[num] = 1;
            }
            return false;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,1,1,3,3,4,3,2,4,2};
            bool result = Solution.ContainsDuplicate(nums);
            Console.WriteLine(result);
        }
    }
}