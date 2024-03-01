class Solution {
    public int longestConsecutive(int[] nums) {
        if(nums.length==0) return 0;
        if(nums.length==1) return 1;
        Arrays.sort(nums);
        int ans= 1;
        int count=1;
        int tmp=0;
        for(int i = 1; i<nums.length; i++){
            if(nums[i-1]==nums[i]){
                tmp++;
                continue;
            }else{
                tmp=0;
            }
            
            if(nums[i-1]+1==nums[i+tmp]){
                count++;
            }else{
                ans = Math.max(count,ans);
                count=1;
            }
        }
        return Math.max(ans,count);
    }
}