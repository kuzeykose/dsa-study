using System.Collections.Generic;

public class Solution {
    public static int LongestConsecutive(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }

        // Diziyi bir HashSet'e ekliyoruz.
        HashSet<int> numSet = new HashSet<int>(nums);

        int longestStreak = 0;

        // Her eleman için ardışık elemanları kontrol ediyoruz.
        foreach (int num in numSet) {
            // Eğer num bir ardışık dizinin başlangıcıysa, ardışık dizini kontrol ediyoruz.
            if (!numSet.Contains(num - 1)) {
                int currentNum = num;
                int currentStreak = 1;

                // Ardışık dizini sağa doğru kontrol ediyoruz.
                while (numSet.Contains(currentNum + 1)) {
                    currentNum++;
                    currentStreak++;
                }

                // En uzun ardışık diziyi güncelliyoruz.
                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }

 