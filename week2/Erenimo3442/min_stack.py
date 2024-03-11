class MinStack:
    stack = list()
    def __init__(self):
        self.stack = list()
        self.minStack = list()

    def push(self, val: int) -> None:
        self.stack.append(val)
        if self.minStack:
            if val > self.minStack[-1]:
                val = self.minStack[-1]
        self.minStack.append(val)
        
    def pop(self) -> None:
        self.stack.pop(-1)
        self.minStack.pop()
        

    def top(self) -> int:
        return self.stack[-1]
        

    def getMin(self) -> int:
        return self.minStack[-1]