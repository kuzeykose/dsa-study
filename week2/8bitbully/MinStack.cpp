// 155. Min Stack
class MinStack {
private:
  struct Item {
    int value;
    Item *next;
    Item(const int &i) : value(i), next(nullptr) {}
  };

  Item *stack;
  Item *min;

  void findNewMin() {
    if (!stack) {
      min = nullptr;
      return;
    }
    Item *current = stack;
    min = stack;
    while (current) {
      if (current->value < min->value) {
        min = current;
      }
      current = current->next;
    }
  }

public:
  MinStack() : stack(nullptr), min(nullptr) {}

  void push(int val) {
    Item *item = new Item(val);
    item->next = stack;
    stack = item;
    if (!min || val < min->value) {
      min = stack;
    }
  }

  void pop() {
    Item *item = stack;
    stack = stack->next;
    if (item == min) {
      findNewMin();
    }
    delete item;
  }

  int top() { return stack->value; }

  int getMin() { return min->value; }
};
