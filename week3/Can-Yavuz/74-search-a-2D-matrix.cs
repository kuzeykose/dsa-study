public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {

        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return false;

       int rows = matrix.Length;
       int cols = matrix[0].Length;
    
        int first = 0;
        int last = cols * rows -1;
        while(first <= last){
        int mid = first + (last - first) / 2;
        int midVal = matrix[mid / cols][mid % cols];
        if(midVal == target){
            return true;
        }else if(midVal  < target){
            first = mid +1;
        }else
            last = mid -1;
        }
        return false;
    }
}

