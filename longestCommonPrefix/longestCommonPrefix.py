class Solution:
    def longestCommonPrefix(strs):
        if len(strs) == 0:
            return ""
        shortest = min(strs,key=len)        # get the shortest string in the list (assume it is the prefix?)
        print(shortest)
        for i, char in enumerate(shortest): # index each character
            for word in strs:               # look at each word
                if word[i] != char:         # if the current character in the word does not match the character in the shortest word
                    return shortest[:i]     # ... return everything up to what did not match
        return shortest                     # by default, return the shortest string if every word has characters that match the shortest word
