import java.util.Arrays;

/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.

Example 1:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:
Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:
Input: nums = [3,3], target = 6
Output: [0,1]
 */
public class TwoSum {
    public static class Solution {
        public int[] twoSum(int[] nums, int target) {
            int sum = 0;
            int arr[] = new int[2];
            for(int i = 0; i<nums.length;i++){
                for(int j=i+1; j<nums.length;j++){
                    sum = nums[i] + nums[j];
                    if (sum == target) {
                        return new int[]{i,j};
                    }
                }
            }
            return null;
        }
    }

    public static void main(String[] args) {

         Solution solution = new Solution();
        //Test Case 1 :
        int nums[] = {2,7,11,15};
        int target = 9;
        System.out.println(Arrays.toString(solution.twoSum(nums,target)));
        //Test Case 2 :
        int nums2[] = {3,2,4};
        int target2 = 6;
        System.out.println(Arrays.toString(solution.twoSum(nums2,target2)));
        //Test Case 3 :
        int nums3[] = {3,3};
        int target3 = 6;
        System.out.println(Arrays.toString(solution.twoSum(nums3,target3)));
        //Test Case 4 :
        int nums4[] = {10,20,30,40,50,60};
        int target4= 110;
        System.out.println(Arrays.toString(solution.twoSum(nums4,target4)));
    }
}
