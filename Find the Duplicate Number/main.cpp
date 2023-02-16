#include <iostream>
#include <vector>
#include <map>
using namespace std;

int findDuplicate(vector<int>& nums)
{
    map<int,int> occurrences;
    int res = 0;
    for (int num : nums)
        if (!occurrences.count(num))
            occurrences.insert(pair<int,int>(num,1));
        else
            res = num;
    return res;
}
int main()
{
    vector<int> nums = {1,3,4,2,2};
    cout << findDuplicate(nums);
    return 0;
}