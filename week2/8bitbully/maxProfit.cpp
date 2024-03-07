// 121. Best Time to Buy and Sell Stock
#include <algorithm>
#include <cstdint>
#include <vector>

int maxProfit(std::vector<int> &prices) {
  int16_t maxProfit = 0;
  int16_t buy = 0, sell = 1; // index

  while (sell < prices.size()) {
    if (prices[buy] < prices[sell]) {
      int16_t profit = prices[sell] - prices[buy];
      maxProfit = std::max(maxProfit, profit);
      sell++;
    } else {
      buy = sell;
      sell++;
    }
  }

  return maxProfit;
}
