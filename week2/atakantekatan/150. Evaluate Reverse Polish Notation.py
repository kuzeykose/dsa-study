class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        stack = collections.deque()
        for token in tokens:
            if token == "+":
                n2 = stack.pop()
                n1 = stack.pop()
                OP = n1 + n2
                stack.append(OP)
            elif token == "-":
                n2 = stack.pop()
                n1 = stack.pop()
                OP = n1 - n2
                stack.append(OP)
            elif token == "*":
                n2 = stack.pop()
                n1 = stack.pop()
                OP = n1 * n2
                stack.append(OP)
            elif token == "/":
                n2 = stack.pop()
                n1 = stack.pop()
                OP = int(n1 / n2)
                stack.append(OP)
            else:
                stack.append(int(token))
        return stack.pop()