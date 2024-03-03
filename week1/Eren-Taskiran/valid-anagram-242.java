class Solution {
    public boolean isAnagram(String s, String t) {
        int[] map = new int[26];
        for(char e: s.toCharArray()){
            map[e-'a']++;
        }
        for(char e: t.toCharArray()){
            map[e-'a']--;
        }
        for(int e:map){
            if(e!=0) return false;
        }
        return true;
    }
}