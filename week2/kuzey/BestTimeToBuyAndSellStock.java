class Solution {
    public int maxProfit(int[] prices) {
        int max = 0;
        int currMin = prices[0];

        for (int each : prices) {
            if (each > currMin)
                max = Math.max(each - currMin, max);
            else
                currMin = Math.min(each, currMin);
        }

        return max;
    }
}