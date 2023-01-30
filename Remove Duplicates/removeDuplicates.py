class Solution:
    def removeDuplicates(self, nums):
        """
        for i in range(len(nums)): # loop to remove duplicates
            num = nums[i]
            if (i + 1) < len(nums):
                next_num = nums[i+1]
            else:
                next_num = nums[-1]
            if num == '_':
                i += 1
            else:
                #print("the number " + str(num) + " appears " + str(nums.count(num)) + " times")
                while nums.count(num) != 1:
                    if next_num == num:
                        nums[i+1] = '_'
                        i += 1

        while '_' in nums:
            nums.remove('_')
        return len(nums)
        """

        # above: not O(n) time

        count = 1 # the first element must be unique, so just start this at 1
        for i in range(len(nums)-1): # -1 to accomodate for how the count starts
            if nums[i] != nums[i+1]: # if current num != next num...
                nums[count] = nums[i+1]
                # use count as index and make it next num
                # what this is doing is rewriting the array from the beginning, then...
                count += 1
        print(nums)
        return(count)
