using System;

public static int MinEatingSpeed(int[] piles, int h)
{
    int left = 1;
    int right = piles.Max();

    while (left < right)
    {
        int mid = left + (right - left) / 2;
        int totalHours = CalculateTotalHours(piles, mid);

        if (totalHours > h)
        {
            left = mid + 1;
        }
        else
        {
            right = mid;
        }
    }

    return left;
    static int CalculateTotalHours(int[] piles, int speed)
    {
        int totalHours = 0;

        foreach (int pile in piles)
        {
            totalHours += (int)Math.Ceiling((double)pile / speed);
        }

        return totalHours;
    }
    //int[] possibleKs = Enumerable.Range(1, piles.Max()).ToArray();
    //int res = h;

    //int left = 0, right = possibleKs.Length - 1;
    //while (left <= right)
    //{
    //    int index = (left + right) / 2;
    //    int currK = possibleKs[index];

    //    int totalHours = 0;
    //    foreach (int pile in piles)
    //    {
    //        totalHours += (int)Math.Ceiling((double)pile / currK);
    //    }

    //    if (totalHours <= h)
    //    {
    //        res = Math.Min(res, currK);
    //        right = index + 1;
    //    }
    //    else if(totalHours >= h)
    //    {
    //        left = index - 1;
    //    }
    //}
    //return res;
}