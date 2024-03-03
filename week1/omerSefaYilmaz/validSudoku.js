/**
 * @param {character[][]} board
 * @return {boolean}
 */
var isValidSudoku = function (board) {
    let rowSet = new Set();
    let colSet = new Set();
    let gridSet = new Set();
  
    // row traverse
    for (let i = 0; i < board.length; i++) {
      if (!rowCheck(i, rowSet, board)) {
        return false;
      }
    }
  
    // col traverse
    for (let i = 0; i < board[0].length; i++) {
      if (!colCheck(i, colSet, board)) {
        return false;
      }
    }
  
    // grid traverse
    for (let i = 0; i < board.length; i += 3) {
      for (let j = 0; j < board[0].length; j += 3) {
        if (!gridCheck(i, j, gridSet, board)) {
          return false;
        }
      }
    }
  
    return true;
  };
  
  const rowCheck = (row, rowSet, board) => {
    for (let i = 0; i < board.length; i++) {
      if (board[row][i] === ".") continue;
      if (rowSet.has(board[row][i])) {
        return false;
      }
      rowSet.add(board[row][i]);
    }
    rowSet.clear();
    return true;
  };
  
  const colCheck = (col, colSet, board) => {
    for (let i = 0; i < 9; i++) {
      if (board[i][col] === ".") continue;
  
      if (colSet.has(board[i][col])) {
        return false;
      }
      colSet.add(board[i][col]);
    }
    colSet.clear();
  
    return true;
  };
  
  const gridCheck = (gridRowStart, gridColStart, gridSet, board) => {
    gridSet.clear();
    for (let i = 0; i < 3; i++) { 
      for (let j = 0; j < 3; j++) { 
        const num = board[gridRowStart + i][gridColStart + j];
        if (num === ".") continue;
        
        if (gridSet.has(num)) {
          return false; 
        }
        gridSet.add(num);
      }
    }
    return true;
  };