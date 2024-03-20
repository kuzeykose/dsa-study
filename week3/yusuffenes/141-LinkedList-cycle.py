def hasCycle(self, head: Optional[ListNode]) -> bool:
        if not head:
            return False
        if not head.next:
            return False
        if head == head.next:
            return True
        
        val1 = head
        val2 = head.next

        while val1 and val2:
            if not val1 and not val2:
                return False
            if val1 == val2:
                return True
            val1=val1.next
            if not val2.next:
                val2 = val2.next
            else:
                val2=val2.next.next
        return False 