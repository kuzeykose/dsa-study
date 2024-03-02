/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function (prices) {
  let maxP = 0;
  for (let left = 0, right = 1; right < prices.length; right++) {
    if (prices[left] < prices[right]) {
      const profit = prices[right] - prices[left];
      maxP = Math.max(maxP, profit);
    } else {
      left = right;
    }
  }
  return maxP;
};
