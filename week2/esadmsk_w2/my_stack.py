class Node:
    def __init__(self, val):
        self.value = val
        self.next = None

class Stack:
    def __init__(self):
        self.top_node = None

    def is_empty(self):
        return self.top_node is None

    def push(self, val):
        new_node = Node(val)
        new_node.next = self.top_node
        self.top_node = new_node

    def pop(self):
        if self.is_empty():
            raise Exception("can't pop from empty stack")
        popped_value = self.top_node.value
        self.top_node = self.top_node.next
        return popped_value

    def top(self):
        if self.is_empty():
            raise Exception("stack has no elements")
        return self.top_node.value

    def size(self):
        size = 0
        current_node = self.top_node
        while current_node:
            size += 1
            current_node = current_node.next
        return size

stack = Stack()
stack.push(456)
print("stack size:", stack.size())
print("top:", stack.top())
print("pop:", stack.pop())
