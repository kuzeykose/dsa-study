def evalRPN(self, tokens: List[str]) -> int:
    oDict = {"+": 1, "-": 2,"*":3, "/": 4}
    stack = []
    for i in tokens:
        if i not in oDict:
            stack.append(int(i))
        else:
            pop1 = stack.pop()
            pop2 = stack.pop()
            if oDict[i] == 1:
                result = pop1 + pop2
            elif oDict[i] == 2:
                result = pop1 - pop2
            elif oDict[i] ==3:
                result = pop1 * pop2
            elif oDict[i] == 4:
                result = int(pop1 / pop2)
            stack.append(result)  
    return stack[0]