using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Solution
    {
        public static string RemoveDuplicates(string s)
        {
            string res = "";

            // use a stack; peek & remove if it's the same
            // in C#, not all stacks work the same
            // so concurrent stack will hold the result & regular stack will put it together

            ConcurrentStack<char> chars = new ConcurrentStack<char>();
            foreach (char c in s)
            {
                char next;
                if ((chars.TryPeek(out next)) && next == c) // regular peek will fail here
                {
                    chars.TryPop(out next);
                    continue;
                }
                chars.Push(c);
            }

            Stack<char> final = new Stack<char>(chars);
            while (final.Count != 0)
                res += final.Pop();

            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = "azxxzy";
            string result = Solution.RemoveDuplicates(s);
            Console.WriteLine(result);
        }
    }
}
