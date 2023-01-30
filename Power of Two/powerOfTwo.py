class Solution:
    def isPowerOfTwo(self, n) -> bool:
        if not (n & (n-1)) and n != 0:
            return True
        return False
        # 0 is not a power of 2
        
        # 4 & 3 == 0100 & 0011 = 0
        # 5 & 4 == 0101 & 0100 = 4
        # 6 & 5 == 0110 & 0101 = 4
        
        # 8 & 7 == 1000 & 0111 = 0
        # 9 & 8 == 1001 & 1000 = 8
        
        # ...
        # all powers of 2 => only one bit for that value is on
        # so ANDing w/ that value - 1 will always return 0
        
print(Solution.isPowerOfTwo(0,0))
