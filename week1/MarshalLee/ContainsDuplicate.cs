public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        foreach (int number in nums)
        {
            if (Array.LastIndexOf(nums, number) != Array.IndexOf(nums, number))
            {
                return true;
            }
        }
        return false;
    }
}