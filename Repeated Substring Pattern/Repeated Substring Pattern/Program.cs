namespace Repeated_Substring_Pattern
{
    public class Solution
    {
        public static bool RepeatedSubstringPattern(string s)
        {
            /*
            int max_index = 0;
            while (max_index < s.Length - 1)
            {
                string substring = "";
                for (int i = 0; i <= max_index; i++)
                {
                    substring += s[i];
                }

                string temp = "";
                while (substring.Length != s.Length) 
                {
                    temp += substring;
                    if (temp == s)
                        return true;
                    else if (temp.Length > s.Length)
                        break;
                }

                if (max_index < s.Length - 1)
                {
                    max_index++;
                    continue;
                }
                else
                    break;
            }
            return false;
            */

            // the above works
            // ... but clearly constructing strings every time results in bad time complexity
                // "time limit exceeded"
            // a scan approach could work better

            char start = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == start)
                {
                    if (IsValidSubstring(i, s)) 
                        return true;
                }
            }

            return false;
        }

        public static bool IsValidSubstring(int substrLen, string s)
        {
            int strLen = s.Length;
            if (substrLen == strLen) // length is one, so it will just jump out
                return false;

            if (strLen % substrLen != 0) // can't form a valid substring
                return false;

            int substrIndex = 0;
            int strIndex = substrLen;

            while (strIndex < s.Length)
            {
                if (s[substrIndex] != s[strIndex]) 
                    return false;

                substrIndex++;
                strIndex++;
                if (substrIndex == substrLen) 
                    substrIndex = 0; // reset
            }

            return true;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "a";
            bool result = Solution.RepeatedSubstringPattern(s);
            Console.WriteLine(result);
        }
    }
}