class Solution:
    def integerReplacement(self, n):
        res = 0

        """
        def isPowerOfTwo(n):
            if (n == 0):
                return False
            while (n != 1):
                    if (n % 2 != 0):
                        return False
                    n = n // 2
                     
            return True
        
        while n != 1:
            res += 1
            
            if n % 2 == 0:
                n >>= 1
                
            else:
                if n == 3: # extra step in this case, so skip once
                    n -= 2
                if ((n + 1) % 2 == 0 and isPowerOfTwo(n + 1)):
                    # worst case occurs between 4 and 2
                    n += 1
                elif ((n - 1) % 2 == 0 and isPowerOfTwo(n - 1)):
                    n -= 1
                elif ((n + 1) % 2 == 0 and not isPowerOfTwo(n + 1)):
                    n -= 1
                else:
                    n += 1
            if n == 1:
                break
        """

        # above doesn't work; a lot of trial and error
        # gives a lot of insight into a valid solution, though...
        
        # base cases: 1, 2, 3, 4
        # case of 1: 0
        # case of 2: 1
        # case of 3: 2
            # adding 1 is the wrong move; need an extra step
        # case of 4: 2
        # [odd #] % 4 == [1, 3], ignoring the case of 3 itself
            # for #'s > 4, if last two bits are 11 (3)...
            # more bits lost if adding 1 is done in this case
        
        while n != 1:
            res += 1
            
            if n % 2 == 0:
                n >>= 1
            elif n % 4 == 1 or n == 3:
                n -= 1
            else:
                n += 1 
            
        return res

print(Solution.integerReplacement(0,10000))
