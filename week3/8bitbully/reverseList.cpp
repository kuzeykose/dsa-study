// 206. Reverse Linked List

struct ListNode {
  int val;
  ListNode *next;
  ListNode() : val(0), next(nullptr) {}
  ListNode(int x) : val(x), next(nullptr) {}
  ListNode(int x, ListNode *next) : val(x), next(next) {}
};

class Solution {
  using N = ListNode;

public:
  ListNode *reverseList(ListNode *head) {
    N *reverse = nullptr;
    N *current = head;

    while (current) {
      N *dummy = current->next;
      current->next = reverse;
      reverse = current;
      current = dummy;
    }

    return reverse;
  }
};
