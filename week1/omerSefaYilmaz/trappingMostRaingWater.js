/**
 * @param {number[]} height
 * @return {number}
 */
var trap = function (height) {
    let left = 0;
    let right = height.length - 1;
    let leftMax = height[left];
    let rightMax = height[right];
    let maxTrappingRain = 0;
  
    while (left < right) {
      if (height[left] < height[right]) {
        if (height[left] > leftMax) {
          leftMax = height[left];
        } else {
          maxTrappingRain += leftMax - height[left]; 
        }
        left++;
      } else {
        if (height[right] > rightMax) {
          rightMax = height[right]; 
        } else {
          maxTrappingRain += rightMax - height[right];
        }
        right--;
      }
    }
    return maxTrappingRain;
  };