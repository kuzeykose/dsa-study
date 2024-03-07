public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> substr = new HashSet<char>();
        int l = 0, r = 0; // left, right index
        int longestSubstring = 0;

        while (r < s.Length)
        {
            if (!substr.Contains(s[r]))
            {
                substr.Add(s[r++]);
                longestSubstring = Math.Max(longestSubstring, r - l);
            }
            else
            {
                substr.Remove(s[l++]);
            }
        }

        return longestSubstring;
    }
}
