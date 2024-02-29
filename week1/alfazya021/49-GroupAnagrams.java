class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
        HashMap<String, List<String>> hmap = new HashMap<>();
        
        for(String i: strs) {
            char[] arr = i.toCharArray();

            Arrays.sort(arr);
            
            String string = new String(arr);
            List<String> array = hmap.get(string);
            
            if(array == null) {
                array = new ArrayList<String>();
                array.add(i);
                hmap.put(string, array);
                continue;
            }
        
            array.add(i);
        }
        return new ArrayList(hmap.values());
    }
}