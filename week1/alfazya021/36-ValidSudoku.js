/**
 * @param {character[][]} board
 * @return {boolean}
 */
var isValidSudoku = function (board) {
  for (let i = 0; i < board.length; i++) {
    let keeper = [];
    let keeper2 = [];

    for (let j = 0; j < board[i].length; j++) {
      keeper.push(0);
      keeper2.push(0);
    }

    for (let j = 0; j < board[i].length; j++) {
      if (board[i][j] != ".") {
        keeper[Number(board[i][j]) - 1]++;

        if (keeper[Number(board[i][j]) - 1] > 1) return false;
      }
      if (board[j][i] != ".") {
        keeper2[Number(board[j][i]) - 1]++;

        if (keeper2[Number(board[j][i]) - 1] > 1) return false;
      }
    }
  }

  for (let i = 0; i < board.length; i += 3) {
    for (let j = 0; j < board[i].length; j += 3) {
      let keeper = [];
      for (let k = 0; k < 9; k++) {
        keeper.push(0);
      }
      
      for (let k = i; k < i + 3; k++) {
        for (let c = j; c < j + 3; c++) {
          if (board[k][c] != ".") {
            keeper[Number(board[k][c]) - 1]++;

            if (keeper[Number(board[k][c]) - 1] > 1) return false;
          }
        }
      }
    }
  }
  return true;
};
