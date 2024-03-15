// 875. Koko Eating Bananas

#include <cstdint>
#include <vector>

using namespace std;

int minEatingSpeed(vector<int> &piles, int h) {
  int64_t left = 1;
  int64_t right = 1e9;

  auto find = [&](int64_t &mid) {
    int64_t hours = 0;
    for (auto &p : piles) {
      hours += (p + mid - 1) / mid;
    }
    return hours;
  };

  while (left <= right) {
    int64_t mid = left + (right - left) / 2;

    if (find(mid) <= h) {
      right = mid - 1;
    } else {
      left = mid + 1;
    }
  }

  return left;
}
