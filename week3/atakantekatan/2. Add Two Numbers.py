class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        ans = None
        d1, d2 = 1, 1
        n1, n2 = 0, 0
        while l1 or l2:
            if l1 != None:
                n1 += d1*l1.val
                d1 *= 10
                l1 = l1.next
            if l2 != None:
                n2 += d2*l2.val
                d2 *= 10
                l2 = l2.next
        SUM = n1 + n2
        for digit in str(SUM):
            new = ListNode(int(digit))
            if ans is None:
                ans = new
            else:
                new.next = ans
                ans = new
        return ans