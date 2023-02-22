#include <iostream>
#include <vector>
using std::cout;
using std::vector;

int numberOfArithmeticSlices(vector<int>& nums)
{
    int n = nums.size();
    if (n < 3)
        return 0;

    int res = 0;
    int difference;

    for (int i = 0; i < n-2; i++)
    {
        difference = nums[i] - nums[i+1];

        for (int j = i+2; j < n; j++) // directly in front of what was previously compared
        {
            if (nums[j-1] - nums[j] == difference)
                res++;
            else
                break;
        }
    }

    return res;
}

int main()
{
    vector<int> nums = {1,2,3,8,9,10};
    cout << numberOfArithmeticSlices(nums);
    return 0;
}