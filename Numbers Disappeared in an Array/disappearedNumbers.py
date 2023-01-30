class Solution:
    def findDisappearedNumbers(self, nums):
        """
        res = []
        for num in range(1,len(nums)+1):
            if num not in nums and num != 0:
                res.append(num)
        return res

        Why does the above fail on large inputs?
        """

        """
        Why does what is below succeed on large inputs?
        """
        
        diff = set()
        for num in range(len(nums)+1):
            if num != 0:
                diff.add(num)
        diff = diff.difference(nums)
        res = []
        for num in diff:
            res.append(num)
        return res


print(Solution.findDisappearedNumbers(0,[1,1]))
