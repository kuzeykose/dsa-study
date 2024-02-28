/**
 * @param {string[]} strs
 * @return {string[][]}
 */

var groupAnagrams = function (strs) {
  const anagramMap = {};

  for (let word of strs) {
    const count = new Array(26).fill(0);

    for (let char of word) {
      count[char.charCodeAt(0) - "a".charCodeAt(0)]++;
    }

    const key = count.join("#");

    if (!anagramMap[key]) {
      anagramMap[key] = [];
    }
    anagramMap[key].push(word);
  }

  return Object.values(anagramMap);
};
