class Solution {
public:
    bool isAnagram(string s, string t) {
        sort(s.begin(), s.end());
        sort(t.begin(), t.end());

        while (s.size() > 0 && t.size() > 0)
            if (s == t)    
                i++;
            else 
                return false;
        return true;

    }
};