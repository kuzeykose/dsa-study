public int[]? TwoSum(int[] nums, int target)
{
    Dictionary<int, int> pairs = new();
    for (int i = 0; i < nums.Length; i++)
    {
        if (pairs.ContainsKey(target - nums[i]))
            return new int[] { pairs[target - nums[i]], i };
        else
            pairs.TryAdd(nums[i], i);
    }
    return default;
}

public int[]? TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length - 1; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                return new int[] { i, j };
            }
        }
    }
    return Array.Empty<int>();
}