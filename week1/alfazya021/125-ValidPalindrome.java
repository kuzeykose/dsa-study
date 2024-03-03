class Solution {
    public boolean isPalindrome(String s) {
        char[] array = s.toLowerCase().toCharArray();
        StringBuilder keeper = new StringBuilder();
        
        for(char i: array) {
            if(i >= 97 && i <= 122 || (i >= 48 && i <= 57)) {
                keeper.append(i);
            }
        }
        
        char[] controller = new String(keeper).toCharArray();
        
        for(int i = 0; i < controller.length / 2; i++) {
            if(controller[i] != controller[controller.length - i - 1]) {
                return false;
            }
        }
        
        return true;
    }
}