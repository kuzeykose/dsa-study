def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
    p=None
    current = head
    if head is None or head.next is None: return head
    while current:
        next = current.next
        current.next = p
        p = current
        current =next
    return p