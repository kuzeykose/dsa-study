using System;

public class LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> list = new();
        int left = 0, right = 0, maxLength = 0;

        while (right < s.Length)
        {
            if (!list.Contains(s[right]))
            {
                list.Add(s[right]);
                right++;
                maxLength = Math.Max(maxLength, list.Count);
            }
            else
            {
                list.Remove(s[left]);
                left++;
            }
        }
        return maxLength;
    }
}
