namespace Valid_Palindrome_II
{
    public class Solution
    {
        public static bool SubstringPalindrome(string s, int start, int end) // helper function for recursion
        {
            while (start < end)
            {
                if (s[start] != s[end])
                    return false;
                start++;
                end--;
            }

            return true;
        }
        
        public static bool ValidPalindrome(string s)
        {
            /*
            string reversedOriginal = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversedOriginal += s[i];
            }

            if (s == reversedOriginal) 
                return true;

            int counter = 0;
            while (counter != s.Length)
            {
                string temp = "";
                for (int i = 0; i < s.Length; i++) 
                { 
                    if (i != counter)
                        temp += s[i];
                }

                string reversedTemp = "";
                for (int i = temp.Length - 1; i >= 0; i--)
                {
                    reversedTemp += temp[i];
                }

                if (temp == reversedTemp)
                    return true;
                counter++;
            }
            */

            // above takes too much time
            // a scan approach will likely a) be faster, and b) require recursion
            // ... but only one parameter, so another function needed

            int start = 0;
            int end = s.Length - 1;

            while (start < end) 
            {
                if (s[start] == s[end])
                {
                    start++;
                    end--;
                }
                else
                    return SubstringPalindrome(s, start + 1, end) || SubstringPalindrome(s, start, end - 1);
            }

            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "abca";
            bool isValid = Solution.ValidPalindrome(s);
            Console.WriteLine(isValid);
        }
    }
}