class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        self.rev = None
        while head:
            new = ListNode(head.val)
            if self.rev is None:
                self.rev = new
            else:
                new.next = self.rev
                self.rev = new
            head = head.next
        return self.rev