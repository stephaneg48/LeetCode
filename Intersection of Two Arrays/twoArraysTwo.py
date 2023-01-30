class Solution:
    def intersect(self, nums1, nums2):
        res = []
        for num in nums1:
            if num in nums2:
                res.append(num)
        return res
        


print(Solution.intersect(0,[1,2,2,1],[2,2]))
