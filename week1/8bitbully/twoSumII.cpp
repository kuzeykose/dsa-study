// 167. Two Sum II - Input Array Is Sorted
#include <vector>

using namespace std;

vector<int> twoSum(vector<int> &numbers, int target) {
  int left = 0, right = numbers.size() - 1;
  vector<int> result(2);

  while (left < right) {
    int total = numbers[left] + numbers[right];
    if (total > target) {
      right -= 1;
    } else if (total < target) {
      left += 1;
    } else {
      result = {left + 1, right + 1};
      return result;
    }
  }

  return result;
}
