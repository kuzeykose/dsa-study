class Solution {
public int lengthOfLongestSubstring(String s) {
    int left = 0, right = 0, maxLength = 0;
    Set<Character> characters = new HashSet<>();

    while (right < s.length()) {
        if (!characters.contains(s.charAt(right))) {
            characters.add(s.charAt(right));
            maxLength = Math.max(maxLength, right - left + 1);
            right++;
        } else {
            characters.remove(s.charAt(left));
            left++;
        }
    }

    return maxLength;
}}