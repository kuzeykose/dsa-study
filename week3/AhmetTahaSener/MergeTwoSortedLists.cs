/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode result = new ListNode();
        ListNode current = result;


        while (!(list1 == null) && !(list2 == null))
        {
            if (list1.val <= list2.val)
            {
                current.next = new ListNode(list1.val);
                current = current.next;
                list1 = list1.next;
            }
            else
            {
                current.next = new ListNode(list2.val);
                current = current.next;
                list2 = list2.next;
            }
        }

        if (list1 == null && list2 != null)
        {
            while (list2 != null)
            {
                current.next = new ListNode(list2.val);
                current = current.next;
                list2 = list2.next;
            }
        }
        else if (list2 == null && list1 != null)
        {
            while (list1 != null)
            {
                current.next = new ListNode(list1.val);
                current = current.next;
                list1 = list1.next;
            }
        }

        return result.next;
    }
}