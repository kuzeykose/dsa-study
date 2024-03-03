class Solution {
    public int[] twoSum(int[] numbers, int target) {
        int i = 0; 
        int j = numbers.length-1;
        while(i<j){
            int mid = (i+j)/2;
            int sum = numbers[i]+numbers[j];
            if(sum==target) return new int[]{i+1,j+1};
            else if(sum<target){ 
                if(numbers[j]+numbers[mid]<target) i=mid+1;
                else i++;
            }
            else{
                if(numbers[i]+numbers[mid]>target)  j=mid-1;
                else j--;
            }
        }
        return new int[0];
    }
}