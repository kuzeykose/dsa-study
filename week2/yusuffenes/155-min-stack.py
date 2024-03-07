
def __init__(self):
    self.stack = []

def push(self, val: int) -> None:
    return self.stack.append(val)

def pop(self) -> None:
    return self.stack.pop()        

def top(self) -> int:
    return self.stack[-1]

def getMin(self) -> int:
    return min(self.stack)
