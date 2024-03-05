#include <unordered_set>
#include <vector>

using namespace std;

class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {
        unordered_set<int> set;
        for (int num : nums)
        {
            set.insert(num);
        }
        return set.size() != nums.size();
    }
};