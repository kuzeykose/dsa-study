# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        count = 0
        countDummy = head
        rangeDummy = head
        tailDummy = head
        while countDummy:
            countDummy = countDummy.next
            count += 1
        if count == 1:
            if n == 1:
                return ListNode('')
        if count == n:
            return head.next
        for i in range(count-n+1):
            tailDummy = tailDummy.next
        for i in range(count-n-1):
            rangeDummy = rangeDummy.next
        rangeDummy.next = tailDummy

        return head
