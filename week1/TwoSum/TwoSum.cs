using System.Collections.Generic;

public class Solution {
    public static int[] TwoSum(int[] nums, int target) {
        // Sayıları ve index'lerini tutan bir sözlük oluşturuyoruz.
        Dictionary<int, int> numIndices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            // Eğer complement değeri sözlükte varsa, bu iki sayının toplamı hedefe eşittir.
            if (numIndices.ContainsKey(complement)) {
                return new int[] { numIndices[complement], i };
            }

            // Sözlüğe güncel sayıyı ve index'ini ekliyoruz.
            if (!numIndices.ContainsKey(nums[i])) {
                numIndices[nums[i]] = i;
            }
        }

        // Eğer çözüm bulunamazsa null döndürüyoruz.
        return null;
    }

    public static void Main() {
        // Örnek kullanımlar
        int[] nums1 = {2, 7, 11, 15};
        int target1 = 9;
        Console.WriteLine($"Example 1: [{string.Join(", ", TwoSum(nums1, target1))}]"); // [0, 1]

        int[] nums2 = {3, 2, 4};
        int target2 = 6;
        Console.WriteLine($"Example 2: [{string.Join(", ", TwoSum(nums2, target2))}]"); // [1, 2]

        int[] nums3 = {3, 3};
        int target3 = 6;
        Console.WriteLine($"Example 3: [{string.Join(", ", TwoSum(nums3, target3))}]"); // [0, 1]
    }
}