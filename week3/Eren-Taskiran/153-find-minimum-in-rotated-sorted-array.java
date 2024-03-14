class Solution {
    public int findMin(int[] nums) {
        int right=nums.length-1;
        int left = 0;
        while(left<right){
            final int mid=(right+left)/2;
            if(nums[mid]<nums[right]){
                right=mid;
            }
            else left = mid+1;
        }
        return nums[left];
    }
}