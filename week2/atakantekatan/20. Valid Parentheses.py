class Solution:
    def isValid(self, s: str) -> bool:
        stack = collections.deque()
        val = {")":"(", "]":"[", "}":"{"}
        for p in s:
            if p in val.values():
                stack.append(p)
            elif p in val and len(stack) == 0:
                return False
            elif p in val:
                if val[p] != stack.pop():
                    return False
        return True if len(stack) == 0 else False