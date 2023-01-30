class Solution:
    def singleNumber(self, nums) -> int:
        d = {}
        for i in range(len(nums)):
            num = nums[i]
            if num not in d:
                d[num] = 1
            else:
                d[num] += 1
        keys = list(d.keys())
        vals = list(d.values())

        return keys[vals.index(1)] # use the index where value for count is 1 to get the key corresponding to it

nums = [4,1,2,1,2]
print(Solution.singleNumber(0,nums))
