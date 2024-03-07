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
