class Solution:
    def numJewelsInStones(self, jewels: str, stones: str) -> int:
        res = 0
        for stone in stones:
            if stone in jewels:
                res += 1
        return res

print(Solution.numJewelsInStones(0,"aA","aAAbbbb"))
