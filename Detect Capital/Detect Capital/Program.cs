using System.Text;

namespace Detect_Capital
{
    public class Solution
    {
        public static bool DetectCapitalUse(string word)
        {
            var res = false;
            var upperCount = 0;
            var lowerCount = 0;

            foreach (char letter in word) // all lower
                if (Char.IsLower(letter))
                    lowerCount++;

            if (lowerCount == word.Length)
            {
                res = true;
                return res;
            }

            foreach (char letter in word) // all upper
                if (Char.IsUpper(letter))
                    upperCount++;

            if (upperCount != word.Length)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    var letter = word[i];
                    if (i == 0)
                    {
                        if (Char.IsUpper(letter) && word.IndexOf(letter) == 0)
                            continue;
                    }

                    else
                    {
                        if (Char.IsUpper(letter))
                        {
                            res = false;
                            break;
                        }
                        else
                            res = true;
                    }
                }
            }

            else
                res = true;
            
            return res;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result = Solution.DetectCapitalUse("FFFFFFFFFFFFFFFFFFFFf");
            Console.WriteLine(result);
        }
    }
}