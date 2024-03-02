class Solution {
public:
    bool isPalindrome(string s) {
        transform(s.begin(),s.end(),s.begin(), ::tolower);
        string ans;
       
        for(char c: s){
            if(isalpha(c) || isdigit(c)){
                ans += c;
            }
        }
        
        int left = 0, right = ans.length()-1;

        while(left < right){
            if(ans[left] != ans[right]){
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
};