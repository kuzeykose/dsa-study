class Solution {
    public boolean isValidSudoku(char[][] board) {
        for(int row = 0; row<9; row++){
            for(int col = 0; col<9; col++){
                char curr=board[row][col];
                if(curr=='.') continue;
                
                int count=0;
                for(int ccol=0; ccol<9; ccol++){
                    if(curr==board[row][ccol]) count++;
                }
                if(count!=1) return false;
                
                count=0;
                for(int crow=0; crow<9; crow++){
                    if(curr==board[crow][col]) count++;
                }
                if(count!=1) return false;
            }
        }
        
        for(int row = 0; row<=6; row+=3){
            for(int col = 0; col<=6; col+=3){
                boolean[] used = new boolean[10]; 
                for(int i = row; i<row+3;i++){
                    for(int j = col; j<col+3; j++){
                        char curr=board[i][j];
                        if(curr=='.') continue;
                        int digit = curr - '0';
                        if(used[digit]) return false; 
                        used[digit] = true;
                    }
                }
            }
        }
        return true;
    }
}
