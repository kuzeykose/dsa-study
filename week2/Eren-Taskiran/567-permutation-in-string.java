class Solution {
    public boolean checkInclusion(String s1, String s2) {
        if(s1.length()>s2.length()){
           return false;
        } 
        char[] arr1 = s1.toCharArray();
        char[] arr2 = s2.toCharArray();
        int[] map = new int[26];
        int[] check = new int[26];
        int j = arr1.length;

        for(int i = 0; i<j;i++){
            check[arr1[i]-'a']++;
            map[arr2[i]-'a']++;
        }
        if(Arrays.equals(check, map)) {
            return true;
        }
        for(int i = j; i<arr2.length;i++){
            map[arr2[i-j]-'a']--;
            map[arr2[i]-'a']++;
            if(Arrays.equals(map,check)) return true;
        }

        
        return false;
    }
    
}
