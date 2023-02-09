#include <iostream>
#include <map>
using std::cout;
using std::endl;
using std::max;
using std::string;
using std::map;

int lengthOfLongestSubstring(string s)
{
    int len = 0;
    int max_len = 0;
    int subarray_index = 0;
    map<char, int> charmap;
    for (int i = 0; i < s.length(); i++)
    {
        // add an entry for the current character
        charmap[s[i]]++;
        len++;
        while (charmap[s[i]] > 1) // if current character's count > 1
        {
            // go back through; remove everything that made the previous substring
            // this makes the current character start a new substring
            charmap[s[subarray_index++]]--;
            len--;
        }
        max_len = max(max_len, len);
    }
    return max_len;
}

int main()
{
    string test = "pwwkew";
    cout << lengthOfLongestSubstring(test) << endl;
    return 0;
}