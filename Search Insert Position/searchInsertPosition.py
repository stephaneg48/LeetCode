class Solution:
    def searchInsert(self, nums, target):
        res = Solution.BS(nums,0,(len(nums)-1), target)
        return res

    def BS(nums, left, right, key):
        if left > right:
            return left # only difference from regular binary search

        mid = (left + right) // 2
        
        if key == nums[mid]:
            return mid
        elif key < nums[mid]:
            return Solution.BS(nums,left,(mid-1),key)
        else:
            return Solution.BS(nums,(mid+1),right,key)
        
nums = [1,3,5,6]
target = 2
print(Solution.searchInsert(0,nums,target))
