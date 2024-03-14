class Solution {
    public ListNode reverseList(ListNode head) {
       
       Stack<Integer> st=new Stack();
        while(head!=null){
           st.push(head.val);
           head=head.next;
        } 
        ListNode ans = new ListNode(0);
        ListNode current = ans;

        while (!st.isEmpty()) {
            int val = st.pop();
            ListNode newNode = new ListNode(val);
            current.next = newNode;
            current = current.next;
        }
        return ans.next;
    }
}