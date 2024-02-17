/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var isAnagram = function (s, t) {
  if (s.length !== t.length) {
    return false;
  }

  const charCount = {};

  for (let i = 0; i < s.length; i++) {
    const charS = s[i];
    const charT = t[i];

    charCount[charS] = (charCount[charS] || 0) + 1;
    charCount[charT] = (charCount[charT] || 0) - 1;
  }

  for (const count of Object.values(charCount)) {
    if (count !== 0) {
      return false;
    }
  }

  return true;
};
