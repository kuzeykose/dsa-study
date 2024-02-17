class Solution {
    public int maxArea(int[] height) {
       int ans=0;
       int j=height.length-1;
       int i = 0;
       while(i<j){
           int h = Math.min(height[i],height[j]);
           int width=j-i;
           ans=Math.max(h*width,ans);
           if(height[i]<height[j]) i++;
            else j--;
       }
       return ans;
    }
}