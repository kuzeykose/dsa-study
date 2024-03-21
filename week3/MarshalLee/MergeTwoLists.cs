using System;

public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    ListNode dummy = new();
    ListNode current = dummy;

    while (list1 != null && list2 != null)
    {
        if (list1.val < list2.val)
        {
            current.next = list1;
            list1 = list1.next;
        }
        else
        {
            current.next = list2;
            list2 = list2.next;
        }
        current = current.next;
    }
    current.next = list1 != null ? list1 : list2;

    return dummy.next;
    //ListNode dummList = list1.val <= list2.val ? list1 : list2;
    //ListNode result = dummList;

    //while (list1 != null || list2 != null)
    //{
    //    if (list1.val <= list2.val)
    //    {
    //        dummList.next = list1;
    //        list1 = list1.next;
    //    }
    //    else
    //    {
    //        dummList.next = list2;
    //        list2 = list2.next;
    //    }
    //}

    //return result;
}