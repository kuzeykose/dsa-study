/**
 * @param {number[]} numbers
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function (numbers, target) {
    let right = numbers.length - 1;
    let result = [];
    for (let i = 0; i < numbers.length; i++) {
      let targetValue = target - numbers[i];
      let left = i + 1;
      while (left <= right) {
        let mid = Math.floor((right + left) / 2);
  
        if (numbers[mid] === targetValue) {
          result.push(i + 1, mid + 1);
        }
        if (numbers[mid] > targetValue) {
          right = mid - 1;
        } else {
          left = mid + 1;
        }
      }
      right = numbers.length - 1;
    }
  
    return result;
  };