/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function (prices) {
  let maxProfit = 0;
  for (let left = 0, right = 1; right < prices.length; right++) {
    if (prices[left] < prices[right]) {
      const profit = prices[right] - prices[left];
      maxP = Math.max(maxProfit, profit);
    } else {
      left = right;
    }
  }
  return maxProfit;
};
