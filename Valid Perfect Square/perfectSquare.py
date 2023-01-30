class Solution:
    def isPerfectSquare(self, num: int) -> bool:
        count = 0
        while count * count != num:
            count += 1
            if count * count > num:
                return False
        return True

print(Solution.isPerfectSquare(0,16))
