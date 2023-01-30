class Solution:
    def lengthOfLastWord(self, s):
        words = s.split()
        return len(words[-1]) # or return len(s.split()[-1])


self = 0
s = "   fly me   to   the moon  "
print(Solution.lengthOfLastWord(self,s))
