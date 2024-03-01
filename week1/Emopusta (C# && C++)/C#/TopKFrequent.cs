public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        foreach(var num in nums){
            if (dict.ContainsKey(num)){
                dict[num]++;
            }
            else{
                dict[num]=1;
            }
        }
        return dict.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
    }
}

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        foreach(var num in nums){
            if (dict.ContainsKey(num)){
                dict[num]++;
            }
            else{
                dict[num]=1;
            }
        }
        var result = new List<int>();
        var lst = new List<int>(dict.Values);
        lst.Sort();
        for(int i = lst.Count -1;i > lst.Count-k-1 ; i--){
                var x = dict.FirstOrDefault(n => n.Value == lst[i]).Key;
                dict.Remove(x);
                result.Add(x);
        }

        return result.ToArray();
    }
}