class MinStack:

    def __init__(self):
        self.A = []
        self.min = []
    def push(self, val: int) -> None:
        self.A.append(val)
        self.min.append(val if not self.min else min(val, self.min[-1]))
    def pop(self) -> None:
        self.A.pop()
        self.min.pop()
    def top(self) -> int:
        return self.A[-1]
    def getMin(self) -> int:
        return self.min[-1]