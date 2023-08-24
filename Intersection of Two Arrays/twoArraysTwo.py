class Solution:
    def intersect(self, nums1, nums2):
        res = []
        dictOne = {}
        dictTwo = {}

        for num in nums1:
            if num not in dictOne:
                dictOne[num] = 1
            else:
                dictOne[num] += 1
                
        for num in nums2:
            if num not in dictTwo:
                dictTwo[num] = 1
            else:
                dictTwo[num] += 1

        if len(nums1) > len(nums2):
            for num in set(nums1):
                if num in dictOne and num in dictTwo:
                    if dictOne[num] == dictTwo[num] or dictOne[num] < dictTwo[num]:
                        for i in range(dictOne[num]):
                            res.append(num)
                    else:
                        for i in range(dictTwo[num]):
                            res.append(num)
        else:
            for num in set(nums2):
                if num in dictOne and num in dictTwo:
                    if dictOne[num] == dictTwo[num] or dictTwo[num] < dictOne[num]:
                        for i in range(dictTwo[num]):
                            res.append(num)
                    else:
                        for i in range(dictOne[num]):
                            res.append(num)
        
        return res
        
print(Solution.intersect(0,[4,9,5],[9,4,9,8,4]))
