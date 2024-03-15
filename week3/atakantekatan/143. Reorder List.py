class Solution:
    def reorderList(self, head: Optional[ListNode]) -> None:
        """
        Do not return anything, modify head in-place instead.
        """
        rev = None
        first = head
        LEN = 0
        while first:
            new = ListNode(first.val)
            if rev is None:
                rev = new
            else:
                new.next = rev
                rev = new
            first = first.next
            LEN += 1
        first = head
        pointer = head
        for i in range(LEN):
            if i % 2 == 0:
                new = ListNode(first.val)
                first = first.next
            else:
                new = ListNode(rev.val)
                rev = rev.next
            if i != 0:
                pointer.next = new
                pointer = pointer.next
            