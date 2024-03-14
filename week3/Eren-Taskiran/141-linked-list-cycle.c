bool hasCycle(struct ListNode *head) {
     if (head == NULL || head->next == NULL) {
        return false;
    }
    
    struct ListNode *slow = head,*fast = head->next;
    
    while (slow != fast) {
        if (fast == NULL || fast->next == NULL) {
            return false;
        }
        slow = slow->next;
        fast = fast->next->next;
    }
    
    return true;
}