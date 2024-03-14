public class Solution
{
    public int MaxProfit(int[] prices) //Time Complexity = O(n)
    {
        Stack<int> priceSt = new Stack<int>();
        int maxDifference = 0;
        int difference;
        int min = prices[0];
        priceSt.Push(prices[0]);

        for (int i = 1; i < prices.Length; i++)
        {
            priceSt.Push(prices[i]);
            if (prices[i] < min)
            {
                min = prices[i];
            }
            difference = priceSt.Peek() - min;

            if (difference > maxDifference)
            {
                maxDifference = difference;
            }
        }

        return maxDifference;
    }
}