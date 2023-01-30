class Solution:
    def isAnagram(self, s, t):
        validAnagram = True
        d1 = {}
        d2 = {}
        for char1 in s:
            if char1 in d1:
                d1[char1] += 1
            else:
                d1[char1] = 1
        for char2 in t:
            if char2 in d2:
                d2[char2] += 1
            else:
                d2[char2] = 1
        if len(d1) == len(d2):
            for key in d1:
                if key not in d2 or d1[key] != d2[key]:
                    validAnagram = False
        else:
            validAnagram = False
        return validAnagram


print(Solution.isAnagram(0,'rat','car'))
