public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums.Contains(target - nums[i]))
            {
                result[0] = i;
                result[1] = Array.IndexOf(nums, target - nums[i]);
                if (!(result[0] == result[1]))
                {
                    return result;
                }
                else
                {
                    continue;
                }
            }
        }
        return result;
    }
}