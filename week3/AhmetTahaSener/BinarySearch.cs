public class Solution
{
    public int Search(int[] nums, int target)
    {
        int min = 0;
        int max = nums.Length - 1;
        int mid = 0;
        while (min <= max)
        {
            mid = (min + max) / 2;
            if (target == nums[mid])
            {
                return mid;
            }
            else if (target > nums[mid])
            {
                min = mid + 1;
            }
            else if (target < nums[mid])
            {
                max = mid - 1;
            }
        }
        return -1;
    }
}
