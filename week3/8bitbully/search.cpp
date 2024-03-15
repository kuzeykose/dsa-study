// 704. Binary Search

#include <cstdint>
#include <vector>

using namespace std;

int search(vector<int> &nums, int target) {
  int32_t left = 0;
  int32_t right = nums.size() - 1;

  while (left <= right) {
    int32_t mid = left + (right - left) / 2;

    if (target > nums[mid]) {
      left = mid + 1;
    } else if (target < nums[mid]) {
      right = mid - 1;
    } else
      return mid;
  }

  return -1;
}
