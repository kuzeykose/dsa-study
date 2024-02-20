/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var isAnagram = function (s, t) {
  if (s.length !== t.length) return false;

  const charCountS = new Array(26).fill(0);
  const charCountT = new Array(26).fill(0);

  for (let i = 0; i < s.length; i++) {
    charCountS[s.charCodeAt(i) - 'a'.charCodeAt(0)]++;
    charCountT[t.charCodeAt(i) - 'a'.charCodeAt(0)]++;
  }

  for (let i = 0; i < 26; i++) {
    if (charCountS[i] !== charCountT[i]) return false;
  }

  return true;
};
