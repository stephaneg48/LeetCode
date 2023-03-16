namespace Most_Common_Word
{
    public class Solution
    {
        public static string MostCommonWord(string paragraph, string[] banned)
        {
            string res = "";

            // trim the words first
            char[] punctuation = { '!', '?', '\'', ',', ';', '.', ' ' };
            string[] words = paragraph.Split(punctuation);
            
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToLower(); // interestingly, can't do this with a foreach loop

            // remove null entries that came as result of loop
            words = words.Where(word => !String.IsNullOrEmpty(word)).ToArray();

            // use hashmap; ignore banned words
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            foreach (string word in words) 
            {
                if (keyValuePairs.ContainsKey(word) && !banned.Contains(word))
                    keyValuePairs[word]++;
                else if (!keyValuePairs.ContainsKey(word) && !banned.Contains(word))
                    keyValuePairs[word] = 1;
            }

            // get the max
            foreach(string key in keyValuePairs.Keys)
            {
                if (keyValuePairs[key] == keyValuePairs.Values.Max())
                {
                    res = key;
                    break;
                }
            }

            return res;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "a, a, a, a, b,b,b,c, c";
            string[] banned = { "a" };
            string result = Solution.MostCommonWord(paragraph, banned);
            Console.WriteLine(result);
        }
    }
}