class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        LIST = []
        profit = 0
        for price in prices:
            if not LIST or price>LIST[0]:
                LIST.append(price)
            else:
                if len(LIST)>1:
                    profit = max(profit,max(LIST)-LIST[0])
                LIST = [price]
        return max(profit,max(LIST)-LIST[0])