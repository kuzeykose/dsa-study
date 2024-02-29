public static int[] TwoSum(int[] numbers, int target)
{
    //if (target != 0)
    //{
    //    int[] remaining = numbers.Where(x => x <= target || x == 0).ToArray();
    //    for (int i = 0, j = remaining.Length - 1; i <= j; i++, j--)
    //    {
    //        if (remaining[i] + remaining[j] == target)
    //            return new int[2] { i + 1, j + 1 };
    //    }
    //}
    //else
    //{
    //    for (int i = 0; i < numbers.Length - 1; i++)
    //    {
    //        for (int j = i + 1; j < numbers.Length; j++)
    //        {
    //            if (numbers[i] + numbers[j] == target)
    //                return new int[2] { i + 1, j + 1 };
    //        }
    //    }
    //}

    //return Array.Empty<int>();
    int i = 0;
    int j = numbers.Length - 1;
    while (numbers[i] + numbers[j] != target)
    {
        if (numbers[i] + numbers[j] < target)
            i++;
        else
            j--;
    }

    return new[] { i + 1, j + 1 };
}