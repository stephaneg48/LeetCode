class Solution:
    def isPalindrome(self, s: str) -> bool:
        import string
        palindrome = ""
        queue = []
        stack = []
        isPalindrome = True
        if len(s) == 1 and s.lower()[0] in string.ascii_lowercase:
            return isPalindrome
        words = s.replace(" ","")

        for char in words.lower():
            if char in string.ascii_lowercase or char in string.digits:
                palindrome += char

        for char in palindrome:
            queue.append(char)
            stack.append(char)
        for char in palindrome:
            char1 = stack[-1]
            char2 = queue[0]
            if char1 != char2:
                isPalindrome = False
                break
            else:
                stack.pop()
                queue.pop(0)
        if not stack and not queue: # if both are empty after getting past the loop
            isPalindrome = True
        else:
            isPalindrome = False
        return isPalindrome

s = "A man, a plan, a canal: Panama"
print(Solution.isPalindrome(0,s))

