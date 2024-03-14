// 3. Longest Substring Without Repeating Characters
#include <algorithm>
#include <set>
#include <string>

int lengthOfLongestSubstring(std::string s) {
  std::set<char> substr;
  int l = 0, r = 0; // left, right index
  int longestSubstring = 0;

  while (r < s.size()) {
    if (!substr.count(s[r])) {
      substr.insert(s[r++]);
      longestSubstring = std::max(longestSubstring, r - l);
    } else
      substr.erase(s[l++]);
  }

  return longestSubstring;
}
