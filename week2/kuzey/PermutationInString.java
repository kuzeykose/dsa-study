class Solution {
    public boolean checkInclusion(String s1, String s2) {
        int[] s1Helper = new int[26];
        int[] s2Helper = new int[26];

        for (int i = 0; i < s1.length(); i++) {
            s1Helper[s1.charAt(i) - 'a']++;
            s2Helper[s2.charAt(i) - 'a']++;
        }

        for (int i = 0; i < s2.length() - s1.length(); i++) {
            if (Arrays.equals(s1Helper, s2Helper))
                return true;
            s2Helper[s2.charAt(i + s1.length()) - 'a']++;
            s2Helper[s2.charAt(i) - 'a']--;
        }

        return Arrays.equals(s1Helper, s2Helper);
    }
}