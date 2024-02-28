public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        char[] sArr = new char[s.Length];
        char[] tArr = new char[t.Length];
        for (int i = 0; i < s.Length; i++)
        {
            sArr[i] = s[i];
        }
        Array.Sort(sArr);
        for (int i = 0; i < t.Length; i++)
        {
            tArr[i] = t[i];
        }
        Array.Sort(tArr);
        if (s.Length == t.Length)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!(sArr[i] == tArr[i]))
                {
                    return false;
                }
            }
            return true;
        }
        return false;
    }
}