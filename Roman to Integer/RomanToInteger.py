class Solution:
    def romanToInt(self,s):
        d = {
            "I":1,
            "V":5,
            "X":10,
            "L":50,
            "C":100,
            "D":500,
            "M":1000,
            }
        
        res = 0
        if len(s) < 1 or len(s) > 15:
            exit()

        i = 0
        while i < len(s):
            current_char = s[i]
            if (i + 1) < len(s): # as long as it's not at the end of the string, get the next char
                next_char = s[i+1] 
            else: # otherwise, the next one must be the last
                next_char = s[-1] 
            if current_char in d: 
                if current_char == "I" and (next_char == "V" or next_char == "X"):
                    res += d[next_char] - 1
                    i += 2 # add twice to avoid repeating
                elif current_char == "X" and (next_char == "L" or next_char == "C"):
                    res += d[next_char] - 10
                    i += 2 # ditto
                elif current_char == "C" and (next_char == "D" or next_char == "M"):
                    res += d[next_char] - 100
                    i += 2 # ditto
                else:
                    res += d[current_char]
                    i += 1

        return res
