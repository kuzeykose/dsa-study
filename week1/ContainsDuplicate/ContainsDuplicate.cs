using System;
using System.Collections.Generic;

public class Solution {
    public static bool ContainsDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in nums)
        {
            if (!set.Add(num))
            {
                return true;
            }
        }

        return false;
    }

    public static void Main()
    {
        // Örnek 1
        int[] nums1 = {1, 2, 3, 1};
        Console.WriteLine($"Example 1: {ContainsDuplicate(nums1)}");

        // Örnek 2
        int[] nums2 = {1, 2, 3, 4};
        Console.WriteLine($"Example 2: {ContainsDuplicate(nums2)}");

        // Örnek 3
        int[] nums3 = {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};
        Console.WriteLine($"Example 3: {ContainsDuplicate(nums3)}");
    }
}