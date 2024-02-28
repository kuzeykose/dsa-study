#include <unordered_map>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        unordered_map<string, vector<string>> dict;
        for(const auto& s : strs) {
            string anagramKey = s;
            sort(anagramKey.begin(), anagramKey.end());
            dict[anagramKey].push_back(s);
        }
        vector<vector<string>> result;
        for(const auto& pair : dict) {
            result.push_back(pair.second);
        }
        return result;
    }
};