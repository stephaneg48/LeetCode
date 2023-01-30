class Solution:
    def missingNumber(self, nums) -> int:
        ceiling = len(nums)
        """
        for num in range(ceiling+1):
            if num not in nums:
                return num
        """
        
        # the above is a solution exclusively thinking in Python
        # here is a way of thinking about this with math...
        # 1 + 2 + 3 + ... = n * (n + 1) / 2
        # this is an infinite series
        # 3 * (4) / 2 = 6, the sum of 1 + 2 + 3
        # if you have the length of the list, the sum should be identical on both sides
        # if not, the difference will return how much they are off; in this case, by exactly one missing number
        # aka the missing value
        
        return ceiling * (ceiling + 1) // 2 - sum(nums)

print(Solution.missingNumber(0,[9,6,4,2,3,5,7,0,1]))
