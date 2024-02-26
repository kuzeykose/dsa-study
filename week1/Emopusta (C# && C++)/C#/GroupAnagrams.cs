public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var result = new Dictionary<string, List<string>>();
        foreach (string s in strs) {
            var arr = s.ToArray();
            Array.Sort(arr);
            var sortedString = new string(arr);

            if (!result.ContainsKey(sortedString)) {
                result[sortedString] = new List<string>();
            }
            result[sortedString].Add(s);
        }
        return new List<IList<string>>(result.Values);
    }
}