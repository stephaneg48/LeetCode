class Solution:
    def canConstruct(self, ransomNote, magazine) -> bool:
        d = {}
        res = ""
        for letter in magazine:
            if letter not in d:
                d[letter] = 1
            else:
                d[letter] += 1
        for letter in ransomNote:
            if letter in d:
                res += letter
                if d[letter] > 1:
                    d[letter] -= 1
                elif d[letter] == 1:
                    del d[letter]
        if res == ransomNote:
            return True
        return False

print(Solution.canConstruct(0,"aab","baa"))
