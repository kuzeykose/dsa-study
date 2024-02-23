class Solution {
    public boolean isAnagram(String s, String t) {
        if (s.length() != t.length()) {
            return false;
        }

        int[] chars = new int[256];
        int index = 0;

        while (index < s.length()) {
            chars[s.charAt(index)]++;
            chars[t.charAt(index)]--;
            index++;
        }

        for (int i : chars) {
            if (i != 0) {
                return false;
            }
        }

        return true;
    }
}