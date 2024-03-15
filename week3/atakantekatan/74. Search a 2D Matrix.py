class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        if target < matrix[0][0] or target > matrix[-1][-1]:
            return False
        l, r = 0 , len(matrix[0]) - 1
        row = 0
        while target > matrix[row][r]:
            row += 1
        while l <= r:
            mid = (l+r) // 2
            
            if target < matrix[row][mid]:
                r = mid - 1
            elif target > matrix[row][mid]:
                l = mid + 1
            elif target == matrix[row][mid]:
                return True 
        return False