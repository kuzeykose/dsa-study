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

