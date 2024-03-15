// 141. Linked List Cycle

struct ListNode {
  int val;
  ListNode *next;
  ListNode(int x) : val(x), next(nullptr) {}
};

class Solution {
public:
  bool hasCycle(ListNode *head) {

    int MAX_ITER = 1e4;

    while (head && MAX_ITER--) {
      head = head->next;
    }

    return head;
  }
};
