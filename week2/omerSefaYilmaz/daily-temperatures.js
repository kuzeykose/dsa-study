/**
 * @param {number[]} temperatures
 * @return {number[]}
 */
var dailyTemperatures = function (temperatures) {
    let stack = [];
    let result = new Array(temperatures.length).fill(0);
  
    for (let i = temperatures.length - 1; i >= 0; i--) {
      while (stack.length > 0 && temperatures[i] >= stack[stack.length - 1].key) {
        stack.pop();
      }
  
      if (stack.length > 0) {// found warmer day
        result[i] = stack[stack.length - 1].value - i;
      }
  
      stack.push({ key: temperatures[i], value: i });
    }
  
    return result;
  };
  