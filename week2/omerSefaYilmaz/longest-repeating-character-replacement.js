/**
 * @param {string} s
 * @param {number} k
 * @return {number}
 */
var characterReplacement = function (s, k) {
    let result = 0;
    let freqMap = {};
    let left = 0;
    let mostFreqChar = 0;
  
    for (let right = 0; right < s.length; right++) {
      let char = s[right];
      if (!freqMap[char]) {
        freqMap[char] = 1;
      } else {
        freqMap[char]++;
      }
  
      mostFreqChar = Math.max(mostFreqChar, freqMap[char]);
      let longestStr = right - left + 1 - mostFreqChar;
  
      if (longestStr > k) {
        freqMap[s[left]]--;
        left++;
      }
  
      result = Math.max(right - left + 1, result);
    }
  
    return result;
  };