class Solution:
    def reverseKGroup(self, head: Optional[ListNode], k: int) -> Optional[ListNode]:
        dummy = ListNode(0)
        dummy.next = head
        first = dummy
        f = dummy
        rev = ListNode(0)
        second = rev
        while first.next:
            cnt = 0
            r = None
            while first.next and cnt < k:
                new = ListNode(first.next.val)
                if r is None:
                    r = new
                else:
                    new.next = r
                    r = new
                cnt += 1
                first = first.next
            if cnt == k:
                second.next = r
                for i in range(k):
                    f = f.next
            while second.next:
                second = second.next
        second.next = f.next
        return rev.next