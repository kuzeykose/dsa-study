//Umut Şenol - LeetCode 49

import java.util.*;

/*
Given an array of strings strs, group the anagrams together. You can return the answer in any order.
An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
Example 2:

Input: strs = [""]
Output: [[""]]
Example 3:

Input: strs = ["a"]
Output: [["a"]]
 */
public class GroupAnagrams {
    public List<List<String>> groupAnagrams(String[] strs) {
        Map<String, List<String>> d = new HashMap<>();
        for(String s : strs){
            char[] t = s.toCharArray();
            Arrays.sort(t);
            String k = String.valueOf(t);
            d.computeIfAbsent(k, key -> new ArrayList<>()).add(s);
        }
        return new ArrayList<>(d.values());
    }

    public static void main(String[] args) {
        GroupAnagrams solution = new GroupAnagrams();
        //Test Case 1 :
        String strs[] = {"eat","tea","tan","ate","nat","bat"};
        System.out.println(solution.groupAnagrams(strs));
        //Test Case 2 :
        String strs2[] = {"a"};
        System.out.println(solution.groupAnagrams(strs2));
        //Test Case 3 :
        String strs3[] = {""};
        System.out.println(solution.groupAnagrams(strs3));
    }
}
