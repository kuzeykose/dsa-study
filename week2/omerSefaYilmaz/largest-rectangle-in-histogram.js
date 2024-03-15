/**
 * @param {number[]} heights
 * @return {number}
 */
var largestRectangleArea = function(heights) {
    let maxArea = 0;
const stack = [];
heights.push(0); 

for (let i = 0; i < heights.length; ++i) {
    while (stack.length > 0 && heights[i] < heights[stack[stack.length - 1]]) {
        const height = heights[stack.pop()];
        const width = stack.length > 0 ? i - stack[stack.length - 1] - 1 : i;
        maxArea = Math.max(maxArea, height * width);
    }
    stack.push(i);
}

return maxArea;
;}