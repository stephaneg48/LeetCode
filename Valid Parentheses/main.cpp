#include <iostream>
#include <stack>
#include <string>
using namespace std;

class Solution {
public:
    bool isValid(string s) {
        stack<char> str;
        for (char paren : s)
        {
            if (paren == '(' || paren == '{' || paren == '[')
                str.push(paren); // push only the left parentheses
            else
            {
                if (str.empty() || ( str.top() == '(' && paren != ')' ) || ( str.top() == '[' && paren != ']' ) || ( str.top() == '{' && paren != '}' ))
                    // stack should not be empty while there are still characters in string
                    //
                    return false;
                str.pop();
            }
        }
        return str.empty(); // if it reaches here then parentheses are valid
    }
};

int main()
{
    Solution obj;
    if(obj.isValid("([)]"))
        printf("true");
    else
        printf("false");
    return 0;
}