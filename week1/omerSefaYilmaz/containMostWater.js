/**
 * @param {number[]} height
 * @return {number}
 */
var maxArea = function (height) {
    let left = 0;
    let right = height.length - 1;
    let maxArea = 0;
    while (left < right) {
      let lowerBound = Math.min(height[left], height[right]);
      let distance = right - left;
      let result = lowerBound * distance;
      maxArea = Math.max(result, maxArea);
      if (height[left] > height[right]) {
        right--;
      } else {
        left++;
      }
    }
  
    return maxArea;
  };
  