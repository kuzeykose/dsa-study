// 217. Contains Duplicate
#include <unordered_set>
#include <vector>

using namespace std;

bool containsDuplicate(vector<int> &nums) {
  // hashSet O(n)
  unordered_set<int> hashSet;

  for (const auto &num : nums) {

    if (hashSet.count(num)) {
      return true;
    }

    hashSet.insert(num);
  }

  return false;
}
