class Solution:
    def isPowerOfThree(self, n) -> bool:
        if n == 1:
            return True
        if n < 3:
            return False
        while (n % 3 == 0):
            n /= 3
        return n == 1

print(Solution.isPowerOfThree(0,1))
