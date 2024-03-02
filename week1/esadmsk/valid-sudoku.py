class Solution(object):
    def isValidSudoku(self, board):
        rows = [set() for _ in range(9)]
        cols = [set() for _ in range(9)]
        boxes = [set() for _ in range(9)]

        for i in range(9):
            for j in range(9):
                if board[i][j] != ".":
                    num = int(board[i][j])
                    box_index = (i // 3) * 3 + j // 3

                    if num in rows[i] or num in cols[j] or num in boxes[box_index]:
                        return False

                    rows[i].add(num)
                    cols[j].add(num)
                    boxes[box_index].add(num)

        return True

