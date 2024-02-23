using System.Collections.Generic;
using System.Linq;

public class Solution {
    public static int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        foreach (int num in nums) {
            if (!frequencyMap.ContainsKey(num)) {
                frequencyMap[num] = 1;
            } else {
                frequencyMap[num]++;
            }
        }

        var sortedItems = frequencyMap.OrderByDescending(pair => pair.Value);

        
        var result = sortedItems.Take(k).Select(pair => pair.Key).ToArray();

        return result;
    }

    public static void Main() {
        // Örnek kullanım
        int[] nums1 = {1, 1, 1, 2, 2, 3};
        int k1 = 2;
        Console.WriteLine($"Example 1: {string.Join(", ", TopKFrequent(nums1, k1))}");

        int[] nums2 = {1};
        int k2 = 1;
        Console.WriteLine($"Example 2: {string.Join(", ", TopKFrequent(nums2, k2))}");
    }
}
