using System;

public int Search(int[] nums, int target)
{
    int left = 0, right = nums.Length - 1;
    while (left <= right)
    {
        int index = (left + right) / 2;
        if (target > nums[index])
            left = index + 1;
        else if (target < nums[index])
            right = index - 1;
        else
            return index;
    }
    return -1;

}