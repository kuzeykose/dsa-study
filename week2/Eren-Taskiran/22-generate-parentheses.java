class Solution {
    public List<String> generateParenthesis(int n) {
        ArrayList<String> res= new ArrayList<>();
        backtrack(res,new StringBuilder(),0,0,n);
        return res;

    }

    public static void backtrack(ArrayList<String> res,StringBuilder curr,int open, int close,int n)
    {
        if(curr.length()==2*n)
        {
            res.add(curr.toString());
            return;
        }
        if(open<n)
        {
            backtrack(res,curr.append("("),open+1,close,n);
            curr.deleteCharAt(curr.length() - 1);
        }
        if(close<open)
        {
            backtrack(res,curr.append(")"),open,close+1,n);
            curr.deleteCharAt(curr.length() - 1);
        }

    }
}