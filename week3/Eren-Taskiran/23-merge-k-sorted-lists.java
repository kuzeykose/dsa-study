class Solution {
    public ListNode mergeKLists(ListNode[] lists) {
        ListNode ans = new ListNode(0);
        ListNode dummy = ans;
        boolean flag = true; 
        while (flag) {
            ListNode min = new ListNode(Integer.MAX_VALUE);
            flag = false; 
            int minIndex = -1;
            for (int i = 0; i < lists.length; i++) {
                if (lists[i] != null && lists[i].val < min.val) {
                    min = lists[i];
                    minIndex = i; 
                    flag = true; 
                }
            }
            if (flag) { 
                dummy.next = min;
                dummy = dummy.next;
                lists[minIndex] = lists[minIndex].next;
            }
        }
        return ans.next;
    }
}
