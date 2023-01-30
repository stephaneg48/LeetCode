class Solution:
    def convertToTitle(self, columnNumber):
        import string
        letters = string.ascii_uppercase
        res = ""
        while columnNumber:
            if columnNumber < 0:
                return None
            index = (columnNumber - 1) % 26
            # convert to index for chr()
            # if mod 26 = 0,  that is A
            # if mod 26 = 25, that is Z
            """res += chr(65+index)"""
            res += letters[index]
            # The chr() method converts an integer to its unicode character and returns it.
            # parameter: number - an integer number in the range 0 to 1,114,111
            # chr(65) = A
            # chr(90) = Z
            # big number -> small number
            # letters at the end of the alphabet added first -> letters at the start of the alphabet added last
            columnNumber = (columnNumber-1) // 26 # integer division to avoid any conversion error
        return res[::-1]
        # return the slice of the string that starts at the end, then step backwards once (-1)
        # because the result comes from the characters being added backwards...
        # :: = "start from the end"

print(Solution.convertToTitle(0,0))
