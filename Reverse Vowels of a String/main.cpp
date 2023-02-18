#include <stack>
#include <string>
using std::stack;
using std::string;

string reverseVowels(string s)
{
    stack<char> letters;
    string vowels = "aeiouAEIOU";

    for (char letter : s)
    {
        if (vowels.find(letter) != std::string::npos)
            letters.push(letter); // found
    }

    string res;

    for (char letter : s)
    {
        if (vowels.find(letter) != std::string::npos)
        {
            res += letters.top();
            letters.pop();
        }
        else
            res += letter;
    }
    return res;
}

int main()
{
    string s = "leetcode";
    string t = reverseVowels(s);
    printf("%s", t.c_str());
    return 0;
}