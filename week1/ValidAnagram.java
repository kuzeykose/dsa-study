//Umut Şenol - LeetCode 242 Solution
/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.
An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
typically using all the original letters exactly once.

        Example 1:

        Input: s = "anagram", t = "nagaram"
        Output: true
        Example 2:

        Input: s = "rat", t = "car"
        Output: false

        Constraints:

        1 <= s.length, t.length <= 5 * 104
        s and t consist of lowercase English letters.
 */
public class ValidAnagram {
    static class Solution {
        public static boolean isAnagram(String s, String t) {

            if(s.length() != t.length()) return false;

            int count[] = new int[26];
            int count2[] = new int[26];

            for(int i = 0; i<s.length(); i++){
                count[s.charAt(i) - 'a']++;
            }
            for(int j= 0; j<t.length(); j++){
                count2[t.charAt(j) - 'a']++;
            }
            for(int k=0; k<count.length; k++){
                if(count[k] != count2[k]){
                    return false;
                }
            }
            return true;
        }
    }
    public static void main(String[] args) {
        //Test Case 1 :
        String s1 = "anagram";
        String t1 = "nagaram";
        System.out.println(Solution.isAnagram(s1, t1));

        //Test Case 2 :
        String s2 = "rat";
        String t2 = "car";
        System.out.println(Solution.isAnagram(s2, t2));
    }
}
