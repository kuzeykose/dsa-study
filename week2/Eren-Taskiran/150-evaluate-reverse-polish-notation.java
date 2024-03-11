class Solution {
    public int evalRPN(String[] tokens) {
        Stack<Integer> stack = new Stack<>();
        String operator="*-/+";
        for(String token : tokens){
            if(token.length()==1 && operator.indexOf(token.charAt(0)) >= 0){
                int second = stack.pop();
                int first = stack.pop();
                int ans=0;
                if(token.equals("+")){
                    ans=first+second;
                }else if(token.equals("-")){
                    ans=first-second;
                }else if(token.equals("/")){
                    ans = first/second;
                }else if(token.equals("*")){
                    ans = first*second;
                }
                stack.push(ans);
            }else{
                stack.push(Integer.parseInt(token));
            }
        }
        return stack.pop();
    }
}