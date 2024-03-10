class Solution {
    public int characterReplacement(String s, int k) {
        int left = 0;
        int maxRepeat = 0;
        int maxLength = 0;
        int[] count = new int[26];

        for (int right = 0; right < s.length(); right++) {
            char c = s.charAt(right);
            count[c - 'A']++;
            maxRepeat = Math.max(maxRepeat, count[c - 'A']);

            while (right - left + 1 - maxRepeat > k) {
                char leftChar = s.charAt(left);
                count[leftChar - 'A']--;
                left++;
            }

            maxLength = Math.max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}