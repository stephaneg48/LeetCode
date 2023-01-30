class Solution:
    def findMaxConsecutiveOnes(self, nums, k) -> int:
        count = 0
        max_count = 0
        k_check = 0
        for i in range(len(nums)):
            if nums[i] == 0:
                nums[i] = 1
                k_check += 1
            if k_check == k:
                break
                
        for i in range(len(nums)):
            if nums[i] == 1:
                count += 1
                if count > max_count:
                    max_count = count
            else:
                count = 0
        return max_count

print(Solution.findMaxConsecutiveOnes(0,[1,1,1,0,0,0,1,1,1,1,0],2))
