class Solution:
    def addTwoNumbers(list1,list2):
        res = []
        list1.reverse()
        list2.reverse()
        # now they're in regular order
        num1 = ""
        num2 = ""
        for i in range(len(list1)):
            num1 += str(list1[i])
        for j in range(len(list2)):
            num2 += str(list2[j])
        val1 = int(num1)
        val2 = int(num2)
        sum_numbers = val1 + val2
        string_sum = str(sum_numbers)
        for k in range(len(string_sum)):
            res.append(int(string_sum[k]))
        # return the sum in reverse as well
        res.reverse()
        return res
