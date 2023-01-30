class Solution:
    def findMaxConsecutiveOnes(self, nums) -> int:
        count = 0
        max_count = 0
        for num in nums:
            if num == 1:
                count += 1
                if count > max_count:
                    max_count = count
            else:
                count = 0
        return max_count

print(Solution.findMaxConsecutiveOnes(0,[1,1,0,1,1,1]))
