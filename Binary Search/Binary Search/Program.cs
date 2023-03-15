namespace Binary_Search
{
    public class Solution
    {
        public static int BS(int[] nums, int L, int R, int key)
        {
            if (L > R)
                return -1;

            double mid = (L + R) / 2;
            var middle = (int)Math.Floor(mid);

            if (key == nums[middle])
                return middle;
            else if (key < nums[middle])
                return Solution.BS(nums,L,middle-1,key);
            else
                return Solution.BS(nums,middle+1,R,key);
        }
        public static int Search(int[] nums, int target)
        {
            int index = Solution.BS(nums, 0, nums.Length - 1, target);
            return index;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = 9;
            int res = Solution.Search(nums, target);
            Console.WriteLine(res);
        }
    }
}