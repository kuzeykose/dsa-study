class Solution {
    public boolean isPalindrome(String s) {
        StringBuilder builder = new StringBuilder();
        for(char e:s.toCharArray()){
            if((e>64 && e<91) || (e>96 && e<123) || (e>47 && e<58)) builder.append(e);
        }
        char[] arr = builder.toString().toLowerCase().toCharArray();
        for(int i = 0; i<arr.length/2;i++){
            if(arr[i] != arr[arr.length-1-i]) return false;
        }
        return true;
    }
}