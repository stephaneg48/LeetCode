class Solution:
    def isPalindrome(self,x):
        divisor = 1
        while (x / divisor) >= 10:
            divisor *= 10

        while x != 0:
            leading_digit = x // divisor
            trailing_digit = x % 10

            if leading_digit != trailing_digit:
                return False

            x = (x % divisor) // 10
            divisor /= 100
            
        return True
