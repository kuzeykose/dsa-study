// 74. Search a 2D Matrix

#include <vector>

using namespace std;

bool searchMatrix(vector<vector<int>> &matrix, int target) {
  int row = matrix.size();
  int column = matrix[0].size();
  int r = row - 1, c = 0;

  while (c < column && r >= 0) {
    int cur = matrix[r][c];

    if (cur < target) {
      c++;
    } else if (cur > target) {
      r--;
    } else
      return true;
  }

  return false;
}
