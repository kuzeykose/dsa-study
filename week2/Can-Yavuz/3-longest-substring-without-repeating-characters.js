/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function (s) {
  let res = 0;
  const characters = new Set();
  for (let l = 0, r = 0; r < s.length; r++) {
    while (characters.has(s[r])) {
      characters.delete(s[l]);
      l++;
    }
    characters.add(s[r]);
    res = Math.max(res, r - l + 1);
  }
  return res;
};
