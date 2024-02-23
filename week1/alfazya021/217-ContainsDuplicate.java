class Solution {
    public boolean containsDuplicate(int[] nums) {
        HashSet<Integer> hmap = new HashSet<>();
        int length = nums.length;
        int size = 0;
        for(int i: nums) {
            if(!hmap.add(i)) return true;
        }
        return false;
    }
}