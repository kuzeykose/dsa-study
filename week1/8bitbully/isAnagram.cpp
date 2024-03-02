// 242. Valid Anagram
#include <string>
#include <unordered_map>
using namespace std;

bool isAnagram(string s, string t) {
  if (s.length() != t.length()) {
    return false;
  }

  unordered_map<char, int> count;

  for (char ch : s) {
    count[ch]++;
  }

  for (char ch : t) {
    if (count.find(ch) == count.end() || count[ch] == 0) {
      return false;
    }
    count[ch]--;
  }

  return true;
}
