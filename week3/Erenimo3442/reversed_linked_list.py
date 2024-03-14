class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        reversedHead = None
        currHead = head
        while currHead != None:
            activeNode = currHead.next
            currHead.next = reversedHead
            reversedHead = currHead
            currHead = activeNode

        return reversedHead