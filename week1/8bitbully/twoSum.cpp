// 1. Two Sum
#include <unordered_map>
#include <vector>
using namespace std;

vector<int> twoSum(vector<int> &nums, int target) {
  unordered_map<int, int> hash_map;

  for (int i = 0; i < (int)nums.size(); i++) {

    int rem = target - nums[i];

    auto it = hash_map.find(rem);

    if (it != hash_map.end()) {
      return {it->second, i};
    }

    hash_map[nums[i]] = i;
  }

  return {};
}
