/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number[]}
 */
var maxSlidingWindow = function (nums, k) {
    let queue = [];
    let result = [];
  
    for (let right = 0; right < nums.length; right++) {
      while (queue && nums[queue[queue.length - 1]] <= nums[right]) {
        queue.pop();
      }
      queue.push(right);
  
      if (queue[0] === right - k) {
        queue.shift();
      }
  
      if (right >= k - 1) {
        result.push(nums[queue[0]]);
      }
    }
    return result;
  };
  