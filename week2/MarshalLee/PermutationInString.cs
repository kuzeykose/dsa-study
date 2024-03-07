using System;

public class PermutationInString
{
    public bool CheckInclusion(string s1, string s2)
    {
        int l = 0, r = 0, i = 0;
        Dictionary<char, int> s1Freq = new Dictionary<char, int>();
        Dictionary<char, int> s2Freq = new Dictionary<char, int>();

        foreach (var ch in s1)
        {
            if (!s1Freq.ContainsKey(ch))
            {
                s1Freq.Add(ch, 1);
            }
            else
            {
                s1Freq[ch] += 1;
            }
        }

        for (r = 0; r < s2.Length; r++)
        {
            if (!s2Freq.ContainsKey(s2[r]))
            {
                s2Freq.Add(s2[r], 1);
            }
            else
            {
                s2Freq[s2[r]] += 1;
            }
            while (r - l + 1 > s1.Length)
            {
                s2Freq[s2[l]] -= 1;
                l++;
            }

            if (r - l + 1 == s1.Length)
            {
                for (i = 0; i < s1.Length; i++)
                {
                    if (!s2Freq.ContainsKey(s1[i]) || s2Freq[s1[i]] != s1Freq[s1[i]])
                    {
                        break;
                    }
                }
                if (i == s1.Length)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
