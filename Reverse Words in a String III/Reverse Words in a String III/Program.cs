namespace Reverse_Words_in_a_String_III
{
    public class Solution
    {
        public static string ReverseWords(string s)
        {
            string res = "";
            string[] words = s.Split(' ');
            int counter = 0;
            foreach (string word in words)
            {
                string reverse = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverse += word[i];
                }
                counter++;
                if (counter == words.Length) 
                    res += reverse;
                else
                    res += reverse + " ";
            }

            return res;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Let's take LeetCode contest";
            string t = Solution.ReverseWords(s);
            Console.WriteLine(t);
        }
    }
}