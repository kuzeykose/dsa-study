class Solution {
    public int lengthOfLongestSubstring(String s) {
        char[] schars = s.toCharArray();
        int ans = 0, i = 0, j = 0;

        Set<Character> hset = new HashSet();
        while (j < schars.length) {
            while (hset.contains(schars[j])) {
                hset.remove(schars[i]);
                i++;
            }

            hset.add(schars[j]);
            j++;
            ans = Math.max(j - i, ans);
        }

        return ans;
    }
}