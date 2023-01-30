class Solution:
    def intersection(self, nums1, nums2):
        res = []
        for num in set(nums1):
            if num in set(nums2):
                res.append(num)
        return res
        


print(Solution.intersection(0,[4,9,5],[9,4,9,8,4]))
