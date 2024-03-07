class Solution:
    def isValid(self, s: str) -> bool:
        stack = []
        for i in s:
            if i == "(" or i == "[" or   i == "{":
                stack.append(i)
            elif i == ")":
                if not stack or not stack[-1] == "(":
                    return False
                    break
                else:
                    stack.pop(-1)
            elif i == "]":
                if not stack or not stack[-1] == "[":
                    return False
                    break
                else:
                    stack.pop(-1)
            elif i == "}":
                if not stack or not stack[-1] == "{":
                    return False
                    break
                else:
                    stack.pop(-1)
        return not stack