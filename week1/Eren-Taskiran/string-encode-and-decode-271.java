class Solution {
    StringBuilder ans;
    public String encode(List<String> strs) {
        ans = new StringBuilder();
        for(String e : strs){
            ans.append(e+":;");
        }
        return ans.toString();
    }

    public List<String> decode(String str) {
        List<String> decList = new ArrayList<>();
        char[] arr = ans.toString().toCharArray();
        String tmp="";
        for(int i = 1; i<arr.length;i++){
            if(arr[i-1] != ':' && arr[i] != ';'){
                tmp+=arr[i-1];
            }else if(arr[i-1] == ':' && arr[i] != ';'){
                tmp+=arr[i-1];
            }
            else{
                decList.add(tmp);
                tmp="";
                i++;
            }
        }
        return decList;
    }
}
