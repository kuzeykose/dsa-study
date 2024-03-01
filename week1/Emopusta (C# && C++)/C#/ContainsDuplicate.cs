public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var set = new HashSet<int>(nums);
        return set.Count() != nums.Length;
    }
}