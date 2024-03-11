class Node:
    def __init__(self, val):
        self.value = val
        self.next = None
        
class Stack:
    def __init__(self):
        self.head = Node("head")
        self.len = 0
    
    def size(self):
        return self.len
    
    def isEmpty(self):
        return True if self.len == 0 else False
    
    def push(self,val):
        newest = Node(val)
        newest.next = self.head.next
        self.head.next = newest
        self.len += 1
        
    def pop(self):
        if self.len == 0:
            raise Exception("Can't pop from empty stack")
        latest = self.head.next
        self.head.next = self.head.next.next
        self.len -= 1
        return latest.value
        
    def top(self):
        if self.len == 0:
            raise Exception("Stack has no elements in it")
        return self.head.next.value
        
stack = Stack()
stack.push(123)
