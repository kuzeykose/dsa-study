def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        for row in matrix:
            el = row[-1]
            if target > el:
                continue
            l, r = 0, len(row) - 1
            while l <= r:
                mid = (l + r) // 2
                if row[mid] == target:
                    return True
                elif row[mid] < target:
                    l += 1
                else:
                    r -= 1
            return False