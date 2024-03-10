def dailyTemperatures(self, temperatures: List[int]):
    n = len(temperatures)
    returnedList = [0] * n
    tempS = [] 
    for i in range(n):
        while tempS and temperatures[tempS[-1]] < temperatures[i]:
            x = tempS.pop()
            returnedList[x] = i - x
        tempS.append(i)
    return returnedList
  
