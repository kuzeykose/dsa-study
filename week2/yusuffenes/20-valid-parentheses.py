def isValid(self, s: str) -> bool:
    sDict = {'(':')', '{':'}', '[':']'}
    ss = []
    for i in s:
        if  i in sDict:
            ss.append(i)
        else:
            if not ss or sDict[ss.pop()] != i:
                return False
    return not ss