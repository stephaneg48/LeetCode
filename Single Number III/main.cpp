#include <iostream>
#include <vector>
#include <map>
using std::cout;
using std::endl;
using std::vector;
using std::map;
using std::pair;

vector<int> singleNumber(vector<int>& nums)
{
    map<int, int> counters;

    for (int i = 0; i < nums.size(); i++)
    {
        if (!counters.count(nums[i]))
            counters.insert(pair<int,int>(nums[i],1));
        else
            counters.at(nums[i]) += 1;
    }

    vector<int> res;
    for (auto it = counters.begin(); it != counters.end(); it++)
        if (it->second == 1)
            res.push_back(it->first);

    return res;
}

int main()
{
    vector<int> nums = {1,2,1,3,2,5};
    vector<int> res = singleNumber(nums);
    for (int i = 0; i < res.size(); i++)
        cout << res[i] << " ";
    return 0;
}