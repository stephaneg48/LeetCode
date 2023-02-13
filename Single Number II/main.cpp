#include <iostream>
#include <vector>
#include <map>
using std::cout;
using std::endl;
using std::vector;
using std::map;
using std::pair;

int singleNumber(vector<int>& nums)
{
    map<int, int> counters;

    for (int i = 0; i < nums.size(); i++)
    {
        if (!counters.count(nums[i]))
            counters.insert(pair<int,int>(nums[i],1));
        else
            counters.at(nums[i]) += 1;
    }

    int res = 0;
    for (auto it = counters.begin(); it != counters.end(); it++)
        if (it->second == 1)
            res = it->first;

    return res;
}

int main()
{
    vector<int> nums = {0,1,0,1,0,1,99};
    int res = singleNumber(nums);
    cout << res;
    return 0;
}