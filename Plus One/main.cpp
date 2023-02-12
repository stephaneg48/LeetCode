#include <iostream>
#include <vector>
#include <math.h>
using std::vector;
using std::cout;

/*
vector<int> plusOne(vector<int>& digits)
{
    long long sum = 0; // bigger container?
    int power = 0;
    for (int i = digits.size() - 1; i >= 0; i--)
    {
        if (i == digits.size() - 1)
            sum += digits[i] + 1;
        else
        {
            long double res = pow(10.0,float(power));
            sum += (digits[i] * res);
        }
        power += 1;
    }

    vector<int> nums = {};

    while (sum % 10 >= 0) // get each digit... modulo, then divide; avoid when sum is 0
    {
        if (sum % 10 == 0 && sum != 0)
        {
            nums.push_back(sum % 10);
            sum /= 10;
        }
        else if (sum % 10 != 0 && sum != 0)
        {
            nums.push_back(sum % 10);
            sum = floor(sum/10);
        }
        else
            break;
    }

    vector<int> copy = {}; // copy backwards

    for (int i = nums.size() - 1; i >= 0; i--)
        copy.push_back(nums[i]);
    return copy;
}
*/

// Above doesn't work... because it can't fit such big numbers at some point
// A computer can store a large, 64-bit integer that's around ~18 quintillion;
// strange question - why store a representation of such a big number if a computer can't hold it anyway?

vector<int> plusOne(vector<int>& digits)
{
    for (int i = digits.size() - 1; i >= 0; --i)
    {
        if (digits[i] == 9) // adjust for carry
            digits[i] = 0;
        else // increment
        {
            digits[i] += 1;
            return digits;
        }
    }

    digits.push_back(0);
    digits[0] = 1; // adjust for carry again
    return digits;
}

int main()
{
    vector<int> numbers = {6,1,4,5,3,9,0,1,9,5,1,8,6,7,0,5,5,4,3};
    vector<int> result = plusOne(numbers);
    for (int i = 0; i < result.size(); i++)
        cout << result[i] << " ";
    return 0;
}