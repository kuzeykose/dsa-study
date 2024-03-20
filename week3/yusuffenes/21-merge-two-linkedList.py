def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        x=y=z=ListNode()
        while list1 and list2:
            if list1.val<list2.val:
                z.next=list1
                list1=list1.next
            else:
                z.next=list2
                list2=list2.next
            z=z.next
        if list1:
            z.next=list1
        else:
            z.next=list2
        return x.next