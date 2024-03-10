class Solution {
public:
    bool isValid(string s) {
        vector<char> st;
        unordered_map<char, char> mappings = {{')', '('}, {']', '['}, {'}', '{'}};
        
        for (char c : s) {
            if (mappings.find(c) != mappings.end()) {
                if (st.empty() || st.back() != mappings[c]) {
                    return false;
                }
                st.pop_back();
            } else {
                st.push_back(c);
            }
        }
        
        return st.empty();
    }
};
 
