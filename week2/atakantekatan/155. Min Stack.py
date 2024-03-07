class Node:
    def __init__(self, val):
        self.value = val
        self.next = None

class MinStack:

    def __init__(self):
        self.head = Node("head")
        self.headsize = 0
        self.minhead = Node("head")
        self.minheadsize = 0

    def push(self, val: int) -> None:
        new = Node(val)
        new.next = self.head.next
        self.head.next = new
        self.headsize += 1

        val = min(val,self.minhead.next.value if self.minheadsize > 0 else val)
        newmin = Node(val)
        newmin.next = self.minhead.next
        self.minhead.next = newmin
        self.minheadsize += 1
        
    def pop(self) -> None:
        last = self.head.next
        self.head.next = self.head.next.next
        self.headsize -= 1

        lastmin = self.minhead.next
        self.minhead.next = self.minhead.next.next
        self.minheadsize -= 1

    def top(self) -> int:
        return self.head.next.value

    def getMin(self) -> int:
        return self.minhead.next.value