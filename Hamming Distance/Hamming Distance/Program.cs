namespace Hamming_Distance
{
    public class Solution
    {
        public static int HammingDistance(int x, int y)
        {
            int res = 0;

            for (int i = 0; i < 32; i++)
            {
                if ((x & (1U << i)) != (y & (1U << i)))
                    res += 1;
            }

            return res;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 1;
            int result = Solution.HammingDistance(x, y);
            Console.WriteLine(result);
        }
    }
    
}