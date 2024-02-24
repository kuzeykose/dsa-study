class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        for i in range(len(board)):
            row = Counter(board[i])
            for num in row:
                if num != "." and row[num]>1:
                    return False

        for k in range(0,9):
            col = Counter(board[0][k])
            for l in range(1,9):
                col += Counter(board[l][k])
            for num in col:
                if num != "." and col[num]>1:
                    return False

        box = Counter()
        for v in range(0,3):
            for m in range(0,9):
                for n in range(v*3,(v*3)+3):
                    box += Counter(board[m][n])
                if m%3 == 2:
                    for num in box:
                        if num != "." and box[num]>1:
                            return False
                    box = Counter()
        return True