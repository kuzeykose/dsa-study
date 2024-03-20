def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        ptr = head
        count = 0
        while(ptr.next):
            if count == n:
                break
            ptr = ptr.next
            count += 1
        if count is not n:
            head = head.next
        else:
            temp = head
            while(ptr.next):
                temp = temp.next
                ptr = ptr.next
            if temp.next:
                temp.next = temp.next.next
            else:
                head = temp.next
        return head