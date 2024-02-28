/**
 * @param {number[]} nums
 * @return {number[][]}
 */
var threeSum = function (nums) {
    let result = [];
  
    nums.sort((a, b) => a - b);
  
    for (let i = 0; i < nums.length; i++) {
      const target = 0 - nums[i];
      let left = i + 1;
      let right = nums.length - 1;
  
      if (i > 0 && nums[i - 1] === nums[i]) {
        continue;
      }
  
      while (left < right) {
        let comp = nums[left] + nums[right];
  
        if (comp === target) {
          result.push([nums[left], nums[right], nums[i]]);
  
          while (left < right && nums[left] === nums[left + 1]) left++;
          while (left < right && nums[right] === nums[right - 1]) right--;
          
          left++;
          right--;
        } else if (comp < target) {
          left++;
        } else if (comp > target) {
          right--;
        }
      }
    }
  
    return result;
  };