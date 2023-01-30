#include <iostream>
#include <cmath>
using namespace std;

/*class Solution {
public:
    string addBinary(string a, string b)
    {
        //cout << "string a:" << a << endl;
        //cout << "string b:" << b << endl;

        long long temp1 = 0;
        for (int i = 0; i < a.length(); i++)
        {
            if (a[i] == '1')
                temp1 += pow(2,a.length()-(1+i));
        }
        long long temp2 = 0;
        for (int i = 0; i < b.length(); i++)
        {
            if (b[i] == '1')
                temp2 += pow(2,b.length()-(1+i));
        }
        int result = temp1 + temp2;
        if (result == 0)
            return "0";
        //cout << "their sum: " << result << endl;

        int out[32];

        // counter for binary array
        int i = 0;
        while (result > 0) {

            // storing remainder in binary array
            out[i] = result % 2;
            result /= 2;
            i++;
        }

        string res;
        //cout << "in binary: ";
        for (int j = i - 1; j >= 0; j--)
            res += to_string(out[j]);

        return res;
    }
};*/

// not big enough?

class Solution {
public:
    string addBinary(string a, string b) {
        string res;
        int carry_bit = 0;
        for (int i = a.size() - 1, j = b.size() - 1; i >= 0 || j >= 0; i--, j--)
        {
            int a_bit = (i >= 0 && a[i] == '1');
            //cout << "a_bit:" << a_bit << endl;
            int b_bit = (j >= 0 && b[j] == '1');
            //cout << "b_bit:" << b_bit << endl;
            res = to_string((a_bit + b_bit + carry_bit) & 1) + res;
            carry_bit = (a_bit + b_bit + carry_bit) >> 1;
        }
        if (carry_bit)
            return '1' + res;
        else 
            return res;
    }
};


int main()
{
    string a = "1010";
    string b = "1011";
    Solution thing;
    string result = thing.addBinary(a,b);
    cout << result << endl;
    return 0;
}