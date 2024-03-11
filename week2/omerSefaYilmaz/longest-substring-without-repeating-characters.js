/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function (s) {
    if (s.length < 1) return 0;
    let stringMap = {};
    let left = 0;
    let longestStrCount = 1;
  
    for (let right = 0; right < s.length; right++) {
      let char = s[right];
        stringMap[char] = right;
  
      if (!stringMap[char]) {
        longestStrCount = Math.max(longestStrCount, right - left);
      } else {
        left = stringMap[char] + 1;
      }
    }
  
    return longestStrCount;
  };
  