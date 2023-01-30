class Solution:
    def thirdMax(self, nums) -> int:
        count = 0
        nums = list(set(nums))
        if len(nums) >= 3:
            while count != 2:
                count +=1
                nums.pop(nums.index(max(nums)))
        else:
            return max(nums)
        return max(nums)
        
print(Solution.thirdMax(0,[2,2,3,1]))
