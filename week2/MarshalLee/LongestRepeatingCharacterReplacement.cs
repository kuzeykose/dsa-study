using System;

public class LongestRepeatingCharacterReplacement
{
    public int CharacterReplacement(string s, int k)
    {
        Dictionary<char, int> charFrequencies = new();
        int result = 0;

        int left = 0;
        int maxFrequency = 0;
        for (int right = 0; right < s.Length; right++)
        {
            charFrequencies[s[right]] = 1 + (charFrequencies.ContainsKey(s[right]) ? charFrequencies[s[right]] : 0);
            maxFrequency = Math.Max(maxFrequency, charFrequencies[s[right]]);

            while ((right - left + 1) - maxFrequency > k)
            {
                charFrequencies[s[left]] -= 1;
                left += 1;
            }

            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}
