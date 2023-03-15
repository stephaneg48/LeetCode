namespace To_Lower_Case
{
    public class Solution
    {
        public static string ToLowerCase(string s)
        {
            string res = "";
            foreach (char c in s)
            {
                if (Char.IsUpper(c))
                    res += Convert.ToChar(c + 32);
                else
                    res += c;
            }
            return res;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // chr(65) = 'A'
            // chr(97) = 'a'
            // difference: 32
            string s = "LOVELY";
            string t = Solution.ToLowerCase(s);
            Console.WriteLine(t);
        }
    }
}