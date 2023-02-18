class Solution:
    def integerBreak(self, n: int) -> int:
        """
        if n == 1 or n == 2:
            return 1

        # find all combinations first

        def findNums(ans, arr, temp, val, index):
            if(val == 0):
                ans.append(list(temp))
                return

            for i in range(index, len(arr)):
                if(val - arr[i]) >= 0:  # no negative values
                    temp.append(arr[i]) # add one element
                    findNums(ans, arr, temp, val-arr[i], i)
                    temp.remove(arr[i]) # remove the element to keep going
                    
        def combinations(arr, val):
            temp = []
            ans = []
         
            findNums(ans, arr, temp, val, 0)
            return ans
         
        arr = [i for i in range(1,n+1)]
        num = arr[-1]
        possible_sums = combinations(arr, num)
        current_max = 0
        for combination in possible_sums:
            res = 1
            for number in combination:
                res *= number
            if res > current_max and len(combination) > 1:
                current_max = res
        return current_max
        """

        # above works, but is inefficient
            # initial (and naive) approach: find the combinations first
            # then go through each one and replace the max
            # results in poor runtime... O(n^3)?
        # also, another edge case: "and len(combination) > 1" is just for 3
            # returns 2

        if n == 1 or n == 2:
            return 1
        if n == 3:
            return 2
        
        num = n // 3                # after 3, think of it as geometric sum... 3^n
        
        if n%3 == 0:                    
            return 3**num           # (3 + 3 + 3 + ...)
        if n%3 == 2:
            return (3**num) * 2     # (3 + 3 + 3 + (...)) + 2     
        if n%3 == 1:
            return 3**(num-1) * 4   # (3 + 3 + 3 + (...)) + 1 -> (3 + 3 + (...)) + 4

print(Solution.integerBreak(0,58))
