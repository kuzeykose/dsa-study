public IList<IList<string>> GroupAnagrams(string[] strs)
{
    List<IList<string>> anagramGroup = new List<IList<string>>();

    for (int i = 0; i < strs.Length; i++)
    {
        if (strs[i] != null)
        {
            List<string> anagrams = new List<string> { strs[i] };
            for (int j = i + 1; j < strs.Length; j++)
            {
                if (strs[j] != null && IsAnagram(strs[i], strs[j]))
                {
                    anagrams.Add(strs[j]);
                    strs[j] = null; // Mark the checked string as null to skip it in future iterations
                }
            }
            anagramGroup.Add(anagrams);
        }
    }

    return anagramGroup;
}
public bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
    {
        return false;
    }
    char[] charArray1 = s.ToCharArray();
    char[] charArray2 = t.ToCharArray();

    Array.Sort(charArray1);
    Array.Sort(charArray2);

    return Enumerable.SequenceEqual(charArray1, charArray2);
}




//Saner solution
public static IList<IList<string>> GroupAnagrams(string[] strs)
{
    Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

    foreach (string str in strs)
    {
        char[] charArray = str.ToCharArray();
        Array.Sort(charArray);
        string sortedStr = new string(charArray);

        if (!anagramGroups.TryGetValue(sortedStr, out var anagrams))
        {
            anagrams = new List<string>();
            anagramGroups[sortedStr] = anagrams;
        }

        anagrams.Add(str);
    }

    return anagramGroups.Values.ToList<IList<string>>();
}




//apparently the most optimal solution
Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

foreach (string s in strs)
{
    int[] count = new int[26];

    foreach (char c in s)
    {
        count[c - 'a']++;
    }

    string key = string.Join(",", count);

    if (anagramGroups.TryGetValue(key, out var anagrams))
    {
        anagrams.Add(s);
    }
    else
    {
        anagrams = new List<string> { s };
        anagramGroups[key] = anagrams;
    }
}

return anagramGroups.Values.ToList<IList<string>>();