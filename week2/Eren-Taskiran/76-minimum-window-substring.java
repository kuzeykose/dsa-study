class Solution {
    public String minWindow(String s, String t) {
        Map<Character, Integer> map = new HashMap<>();
        for (char ch : t.toCharArray()) {
            map.put(ch, map.getOrDefault(ch, 0) + 1);
        }
        int start = 0;
        int substr = 0;
        int matched = 0;
        int ans = Integer.MAX_VALUE;
        for (int i = 0; i < s.length(); i++) {
            char c = s.charAt(i);
            if (map.containsKey(c)) {
                map.put(c, map.get(c) - 1);
                if (map.get(c) == 0)
                    matched++;
            }
            while (matched == map.size()) {
                if (ans > i - start + 1) {
                    ans = i - start + 1;
                    substr = start;
                }
                char newChar = s.charAt(start++);
                if (map.containsKey(newChar)) {
                    if (map.get(newChar) == 0)
                        matched--;
                    map.put(newChar, map.get(newChar) + 1);
                }
            }
        }
        return ans == Integer.MAX_VALUE ? "" : s.substring(substr, substr + ans);
    }
}