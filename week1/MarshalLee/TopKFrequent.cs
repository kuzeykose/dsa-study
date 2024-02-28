public static int[] TopKFrequent(int[] nums, int k)
{
    Dictionary<int, int> frequencyDictionary = new();

    foreach (var num in nums)
    {
        if (frequencyDictionary.TryGetValue(num, out int value))
        {
            frequencyDictionary[num] = ++value;
        }
        else
        {
            frequencyDictionary[num] = 1;
        }
    }
    var sortedFrequencies = frequencyDictionary
        .OrderByDescending(pair => pair.Value)
        .Take(k);

    int[] result = sortedFrequencies.Select(pair => pair.Key).ToArray();

    return result;
}