class Solution:
    def isValid(self,s):
        stack = []
        for char in s:
            if char == '(' or char == '[' or char == '{':
                stack.append(char)
            else:
                if not stack or (stack[-1] == '(' and char != ')') or (stack[-1] == '[' and char != ']') or (stack[-1] == '{' and char != '}'):
                    return False
                stack.pop()  
        return (len(stack) == 0) # should be empty if it's valid at the end
                                 # otherwise it hit the if statement
    
print(Solution.isValid(0,"["))
