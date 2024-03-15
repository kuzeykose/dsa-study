class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        dummy = ListNode(0)
        pointer = dummy

        while list1 and list2:
            if list1.val < list2.val:
                pointer.next = ListNode(list1.val)
                list1 = list1.next
                pointer = pointer.next
            elif list2.val < list1.val:
                pointer.next = ListNode(list2.val)
                list2 = list2.next
                pointer = pointer.next
            elif list1.val == list2.val:
                pointer.next = ListNode(list1.val)
                pointer.next.next = ListNode(list2.val)
                list1 = list1.next
                list2 = list2.next
                pointer = pointer.next.next
        
        if list1:
            pointer.next = list1
        elif list2:
            pointer.next = list2
        
        return dummy.next