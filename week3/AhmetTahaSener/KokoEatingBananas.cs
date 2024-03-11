public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int mid = 0;
        int min = 1;
        int max = piles.Max();
        int result = max;

        while (min <= max)
        {
            mid = min + (max - min) / 2;
            int check = BinarySearchCheck(piles, mid);

            if (check < 0)
            {
                break;
            }

            if (h >= check)
            {
                result = Math.Min(result, mid);
                max = mid - 1;
            }
            else
            {
                min = mid + 1;

            }
        }
        return result;
    }

    public int BinarySearchCheck(int[] piles, int m)
    {
        int result = 0;

        for (int i = 0; i < piles.Length; i++)
        {
            result += (int)Math.Ceiling((double)piles[i] / (double)m);
        }

        return result;
    }
}