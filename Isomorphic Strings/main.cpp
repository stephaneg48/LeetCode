#include <iostream>
#include <string>
#include <map>
using std::string;
using std::map;
using std::pair;
using std::cout;
using std::boolalpha;

/*
bool isIsomorphic(string s, string t)
{
    if (s.length() != t.length())
        return false;

    map<char,char> char_relations;
    for (int i = 0; i < s.length(); i++)
    {
        if (!char_relations.count(s[i]))
            if (!char_relations.count(t[i]))
                char_relations.insert(pair<char,char>(s[i],t[i]));
            else
            {
                for (auto it = char_relations.begin(); it != char_relations.end(); it++)
                {
                    if (it->second == t[i]) // cannot be mapped to more than once
                        return false;
                }
            }

        else if (char_relations.count(s[i]) && t[i] != char_relations.at(s[i]))
            // entry should be the same
            return false;
        else
            continue;
    }
    return true;
}
*/

// above doesn't work... 40/44 test cases passed
// why? one map seems to not be enough
    // also completely ignores the iterator (or appears to when debugging...)

bool isIsomorphic(string s, string t)
{
    if (s.length() != t.length())
        return false;

    map<char,char> dict_one; // s -> t
    map<char,char> dict_two; // t -> s
    // two dictionaries, so that whatever is about to be mapped can be checked both ways
    // if one way doesn't match the other, not isomorphic

    for (int i = 0; i < s.length(); i++)
    {
        if (dict_one.find(s[i]) != dict_one.end())
            if (dict_one[s[i]] != t[i])
                return false;

        if (dict_two.find(t[i]) != dict_two.end())
            if (dict_two[t[i]] != s[i])
                return false;

        dict_one.insert(pair<char,char>(s[i],t[i]));
        dict_two.insert(pair<char,char>(t[i],s[i]));
    }
    return true;
}

int main()
{
    string s = "badc";
    string t = "baba";
    bool res = isIsomorphic(s,t);
    cout << boolalpha;
    cout << res;
    return 0;
}