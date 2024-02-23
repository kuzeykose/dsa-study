class Solution {
    public int[] twoSum(int[] numbers, int target) {
        int left = 0, right = numbers.length - 1;
        
        while(left < right) {
            if(target - numbers[left] < numbers[right]) {
                right--;
            } else if(target - numbers[left] > numbers[right]) {
                left++;
            } else {
                break;
            }
        }
        
        int[] answer = {left+1, right+1};
        
        return answer;
    }
}