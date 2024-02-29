public class Solution {
    public bool IsAnagram(string s, string t) {
        var sArr = s.ToArray();
        var tArr = t.ToArray();
        Array.Sort(sArr);
        Array.Sort(tArr);
        return (new string(sArr) == new string(tArr));
    }
}

public class Solution {
    public bool IsAnagram(string s, string t) {
        var sArr = s.ToArray();
        var tArr = t.ToArray();
        Array.Sort(sArr);
        Array.Sort(tArr);
        if (sArr.Length != tArr.Length) return false;

        for(int i = 0; i<sArr.Length; i++){
            if (sArr[i] != tArr[i]) return false;
        }
        return true;
    }
}