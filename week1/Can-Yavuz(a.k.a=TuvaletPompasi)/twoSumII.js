/**
 * @param {number[]} numbers
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function (numbers, target) {
  l = 0;
  r = numbers.length - 1;

  while (l < r) {
    const currentSum = numbers[l] + numbers[r];
    if (currentSum === target) {
      return [l + 1, r + 1];
    } else if (currentSum < target) {
      l++;
    } else {
      r--;
    }
  }
  return [];
};
