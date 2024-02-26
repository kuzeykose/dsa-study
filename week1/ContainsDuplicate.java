//217.Contains Duplicate - LeetCode. // 
//Umut Şenol (usenol)

 /* Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

        Example 1:

        Input: nums = [1,2,3,1]
        Output: true
        Example 2:

        Input: nums = [1,2,3,4]
        Output: false
        Example 3:

        Input: nums = [1,1,1,3,3,4,3,2,4,2]
        Output: true

        Constraints:

        1 <= nums.length <= 105
        -109 <= nums[i] <= 109

  */
public class ContainsDuplicate {
     static class Solution {
         public static boolean containsDuplicate(int[] nums) {
             for(int i=0; i<nums.length-1; i++){
                 for(int j= i+1; j<nums.length; j++){
                     if(nums[i] == nums[j]){
                         return true;
                     }
                 }
             }
             return false;
         }
     }

    public static void main(String[] args) {
         //Test Case 1:
        int nums[] = {1,2,3,1};
        System.out.println(Solution.containsDuplicate(nums));
        //Test Case 2:
        int nums2[] = {1,2,3,4};
        System.out.println(Solution.containsDuplicate(nums2));
        //Test Case 3:
        int nums3[] = {1,1,1,3,3,4,3,2,4,2};
        System.out.println(Solution.containsDuplicate(nums3));
        }
    }
