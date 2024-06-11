# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def deleteDuplicates(self, head):
        current = head
        if current == None:
            return None # the list is empty
        while current != None and current.next != None:
            if current.val == current.next.val:
                current.next = current.next.next # skip to the next node
            else:
                current = current.next
        return head

# the constraints make reaching the solution straightforward
