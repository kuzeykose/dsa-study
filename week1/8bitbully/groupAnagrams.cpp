// 49. Group Anagrams
#include <string>
#include <unordered_map>
#include <vector>

using namespace std;

vector<vector<string>> groupAnagrams(vector<string> &strs) {

  unordered_map<string, vector<string>> maps;

  for (string s : strs) {
    vector<int> key(26);
    for (char c : s) {
      key[c - 'a']++;
    }
    string keystr;
    for (int num : key) {
      keystr += to_string(num) + '#';
    }
    maps[keystr].push_back(s);
  }

  vector<vector<string>> result;
  // transform(maps.begin(), maps.end(), back_inserter(result),
  //          [](const auto &pair) { return pair.second; });
  for (const auto &pair : maps) {
    result.push_back(pair.second);
  }

  return result;
};
