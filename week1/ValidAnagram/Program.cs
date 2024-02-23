using System.Collections.Generic;

public class Solution {
    public static bool IsAnagram(string s, string t) {
        
        if (s.Length != t.Length) {
            return false;
        }

      
        Dictionary<char, int> charFrequencyS = new Dictionary<char, int>();
        Dictionary<char, int> charFrequencyT = new Dictionary<char, int>();

       
        foreach (char c in s) {
            if (charFrequencyS.ContainsKey(c)) {
                charFrequencyS[c]++;
            } else {
                charFrequencyS[c] = 1;
            }
        }

        
        foreach (char c in t) {
            if (charFrequencyT.ContainsKey(c)) {
                charFrequencyT[c]++;
            } else {
                charFrequencyT[c] = 1;
            }
        }

        
        return AreDictionariesEqual(charFrequencyS, charFrequencyT);
    }

  
    private static bool AreDictionariesEqual(Dictionary<char, int> dict1, Dictionary<char, int> dict2) {
        if (dict1.Count != dict2.Count) {
            return false;
        }

        foreach (var kvp in dict1) {
            if (!dict2.ContainsKey(kvp.Key) || dict2[kvp.Key] != kvp.Value) {
                return false;
            }
        }

        return true;
    }

    public static void Main() {
        // Örnek kullanım
        string s1 = "anagram";
        string t1 = "nagaram";
        Console.WriteLine($"Example 1: {IsAnagram(s1, t1)}"); // true

        string s2 = "rat";
        string t2 = "car";
        Console.WriteLine($"Example 2: {IsAnagram(s2, t2)}"); // false
    }
}
