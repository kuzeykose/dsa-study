class Solution:
    def dailyTemperatures(self, temperatures: List[int]) -> List[int]:   
        stack = deque()
        temps = [0] * len(temperatures)
        l, r = 0, len(temps)-1
        for i in reversed(range(len(temperatures))):
            temp = temperatures[i]
            if not stack:
                stack.append([temp,i])
            elif temp > stack[-1][0]:
                while stack and temp >= stack[-1][0]:
                    stack.pop()
                if stack:
                    temps[i] = stack[-1][1] - i
                stack.append([temp,i])
            elif temp < stack[-1][0]:
                temps[i] = stack[-1][1] - i
                stack.append([temp,i])
            elif temp == stack[-1][0]:
                stack.pop()
                if stack:
                    temps[i] = stack[-1][1] - i
                stack.append([temp,i])
        return temps