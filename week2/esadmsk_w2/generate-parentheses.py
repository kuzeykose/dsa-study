class Solution(object):
    def generateParenthesis(self, n):
        def backtrack(combination, open_count, close_count):
            if len(combination) == 2 * n:
                result.append(combination)
                return
            if open_count < n:
                backtrack(combination + '(', open_count + 1, close_count)
            if close_count < open_count:
                backtrack(combination + ')', open_count, close_count + 1)

        result = []
        backtrack('', 0, 0)
        return result

