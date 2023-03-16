namespace Self_Dividing_Numbers
{
    public class Solution
    {
        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            int[] res = new int[left + right];
            int j = 0;
            for (var i = left; i <= right; i++)
            {
                char[] chars = i.ToString().ToCharArray();
                int size = chars.Length;
                int counter = 0;
                foreach (char digit in chars)
                {
                    var value = (int)Char.GetNumericValue(digit);
                    if (value != 0 && i % value == 0)
                        counter++;
                }
                if (counter == size)
                {
                    res[j] = i;
                    j++;
                }
            }

            res = res.Where(val => val != 0).ToArray();
            return res;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int left = 1, right = 22;
            var result = Solution.SelfDividingNumbers(left, right);
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }    
        }
    }
}