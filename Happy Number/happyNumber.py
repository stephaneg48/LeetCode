class Solution:
    def isHappy(self, n) -> bool:
        isHappy = False
        num = n
        numStr = str(num)
        sumNum = 0
        d = {}
        while sumNum != 1:
            sumNum = 0
            for char in numStr:
                digit = int(char)
                sumNum += digit**2
            if sumNum not in d:
                d[sumNum] = 1
            elif sumNum in d:
                d[sumNum] += 1
            if sumNum == 1:
                isHappy = True
                break
            else:
                numStr = str(sumNum)
            if d[sumNum] > 1:
                break
        return isHappy

print(Solution.isHappy(0,7))
