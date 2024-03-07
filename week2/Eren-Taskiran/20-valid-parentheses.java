class Solution {
    public boolean isValid(String s) {
        Stack<Character> st = new Stack();
        for(char e:s.toCharArray()){
            if(e=='(' || e=='[' || e=='{') st.add(e);
            else if(!st.isEmpty()){
                char curr = st.pop();
                if( (curr=='(' && e!=')') ||
                    (curr=='[' && e!=']') ||
                    (curr=='{' && e!='}')) return false;
            }else return false;
        }
        return st.isEmpty();
    }
}