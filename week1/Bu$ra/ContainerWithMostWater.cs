public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right) {
            // Container'in genişliği
            int width = right - left;

            // Container'in yüksekliği, daha düşük olan duvarın yüksekliği
            int h = Math.Min(height[left], height[right]);

            // Mevcut container'ın alanı
            int area = width * h;

            // Max alanı güncelle
            maxArea = Math.Max(maxArea, area);

            // Daha düşük olan duvarı içe doğru hareket ettir
            if (height[left] < height[right]) {
                left++;
            } else {
                right--;
            }
        }
        return maxArea;
    
    }    
}
