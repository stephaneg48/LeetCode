class Solution:
    def isUgly(self, n: int) -> bool:
        if n == 1:
            return True
        acceptable = [2, 3, 5]
        for num in acceptable:
            while n % num == 0 < n:
                n /= num
        return n == 1

print(Solution.isUgly(0,14))
