/**
 * @param {number[]} nums
 * @return {boolean}
 */
var containsDuplicate = function (nums) {
  let duplicateArr = [];
  for (let x = 0; x < nums.length; x++) {
    if (nums[x] === 0) {
      continue;
    }
    for (let y = 0; y < nums.length; y++) {
      if (x === y) {
        continue;
      } else {
        if (x !== y && nums[x] === nums[y]) {
          duplicateArr.push(nums[x]);
        }
      }
    }
  }
  return [...new Set(duplicateArr)];
};
