class Solution {
    public String minWindow(String s, String t) {
        if (t.length() > s.length())
            return "";

        int count = 0;
        int start = 0;
        int tLength = t.length();
        String ans = "";

        int[] tHash = new int[128];
        int[] sHash = new int[128];

        for (char e : t.toCharArray()) {
            tHash[e]++;
        }

        int len = s.length() + 1;
        for (int i = 0; i < s.length(); i++) {
            sHash[s.charAt(i)]++;

            if (sHash[s.charAt(i)] <= tHash[s.charAt(i)])
                count++;

            if (count == tLength) {
                while (sHash[s.charAt(start)] > tHash[s.charAt(start)] || tHash[s.charAt(start)] == 0) {
                    if (sHash[s.charAt(start)] > tHash[s.charAt(start)]) {
                        sHash[s.charAt(start)]--;
                    }
                    start++;
                }

                if (len > i - start + 1) {
                    len = i - start + 1;
                    ans = s.substring(start, start + len);
                }

            }
        }

        return ans;
    }
}