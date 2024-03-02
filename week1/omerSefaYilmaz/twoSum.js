/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */

var twoSum = function (nums, target) {
    let remainPairs = {};
    let result = [];
    for (let i = 0; i < nums.length; i++) {
      if (remainPairs.hasOwnProperty([nums[i]])) {
        result.push(i, nums.indexOf(remainPairs[nums[i]]));
      } else {
        remainPairs[target - nums[i]] = nums[i];
      }
    }
    return result;
  };