import java.util.Arrays;

/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters
and removing all non-alphanumeric characters, it reads the same forward and backward.
Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

Example 1:
Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.
Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.
Example 3:

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.
 */
public class ValidPolindrome {
    public static class Solution {
        public static boolean isPalindrome(String s) {
            String str = s.toLowerCase().replaceAll("[^a-zA-Z0-9]", "");
            int i = 0;
            int j = str.length()-1;
            while(i <= j){
                if(str.charAt(i) != str.charAt(j)){
                    return false;
                }
                i++;
                j--;
            }
            return true;
            }
        }
    public static void main(String[] args) {
        Solution validPolindrome = new Solution();
        //Test Case 1 :
        String s = "A man, a plan, a canal: Panama";
        System.out.println(validPolindrome.isPalindrome(s));
        //Test Case 2 :
        String s1 = "race a car";
        System.out.println(validPolindrome.isPalindrome(s1));
        //Test Case 3 :
        String s2 = " ";
        System.out.println(validPolindrome.isPalindrome(s2));
    }
}
