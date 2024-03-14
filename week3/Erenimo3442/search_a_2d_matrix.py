class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        for row in matrix:
            min = 0
            max = len(row) - 1
            while min <= max:
                med = (min + max) // 2
                if row[med] < target:
                    min = med + 1
                elif row[med] > target:
                    max = med - 1

                if row[med] == target:
                    return True
        return False