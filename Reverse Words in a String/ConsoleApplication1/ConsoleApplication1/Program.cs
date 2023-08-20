using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Solution
    {
        public static string ReverseWords(string s)
        {
            string res = "";
            string[] words = s.Split(' ');
            int counter = 0;

            words = words.Where(word => !String.IsNullOrEmpty(word)).ToArray();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                counter++;
                if (counter == words.Length)
                    res += words[i];
                else
                    res += words[i] + " ";
            }

            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = "  hello world  ";
            string result = Solution.ReverseWords(s);
            Console.WriteLine(result);
        }
    }
}
