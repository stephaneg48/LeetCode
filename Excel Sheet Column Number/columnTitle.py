class Solution:
    def titleToNumber(self, columnTitle):
        import string
        letters = string.ascii_uppercase
        res = 0
        for index, letter in enumerate(columnTitle[::-1]):
            # read backwards, same way as converting the other way
            res += 26**index*(letters.index(letter)+1)
        return res


print(Solution.titleToNumber(0,"HU"))
