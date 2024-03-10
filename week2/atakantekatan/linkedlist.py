class Node:
    def __init__(self, val):
        self.value = val
        self.next = None
        
class LinkedList:
    def __init__(self):
        self.head = None
        self.len = 0
        
    def size(self):
        return self.len
    
    def clear(self):
        self.head = None
        self.len = 0
    
    def appendleft(self,val):
        new = Node(val)
        if self.head == None:
            self.head = new
        else:
            new.next = self.head
            self.head = new
        self.len += 1
    
    def append(self,val):
        new = Node(val)
        if self.head == None:
            self.head = new
        else:
            node = self.head
            while node.next:
                node = node.next
            node.next = new
        self.len += 1
    
    def popleft(self):
        if self.len == 0:
            raise Exception("You can't pop from empty linked list")
        remove = self.head.value
        self.head = self.head.next
        self.len -= 1
        return remove
    
    def pop(self):
        if self.len == 0:
            raise Exception("You can't pop from empty linked list")
        node = self.head
        if self.len == 1:
            remove = node.value
            self.head = None
        else:
            while(node.next.next):
                node = node.next
            remove = node.next.value
            node.next = None
        self.len -= 1
        return remove
        
    def reverse(self):
        if self.len == 0:
            raise Exception("You can't reverse an empty linked list")
        node = self.head
        new = Node(node.value)
        self.reversed = new
        while node.next:
            node = node.next
            new = Node(node.value)
            new.next = self.reversed
            self.reversed = new
        self.head = self.reversed
        
a = LinkedList()
a.append(1)
a.append(2)
a.append(3)
a.appendleft(4)