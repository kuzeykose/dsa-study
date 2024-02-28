/**
 * @param {string} s
 * @return {boolean}
 */
var isPalindrome = function (s) {
  const cleanString = s.replace(/[^A-Za-z0-9]/g, '').toLowerCase();
  const reversedString = cleanString.split('').reverse().join('');
  return cleanString === reversedString;
};
