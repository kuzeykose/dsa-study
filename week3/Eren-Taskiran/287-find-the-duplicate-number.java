class Solution {
    public int findDuplicate(int[] nums) {
        int freq[] = new int[nums.length];
        for(int num:nums){
            freq[num]++;
            if(freq[num]>1){
                return num;
            }
        }
        return nums[0];
    }
}