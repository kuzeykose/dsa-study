public class Solution {
    public static int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;

       
        int[] leftProducts = new int[n];
        leftProducts[0] = 1;
        for (int i = 1; i < n; i++) {
            leftProducts[i] = leftProducts[i - 1] * nums[i - 1];
        }

        
        int rightProduct = 1;

      
        int[] result = new int[n];

        
        for (int i = n - 1; i >= 0; i--) {
            result[i] = leftProducts[i] * rightProduct;
            rightProduct *= nums[i];
        }

        return result;
    }

    public static void Main() {
        // Örnek kullanım
        int[] nums1 = {1, 2, 3, 4};
        Console.WriteLine($"Example 1: [{string.Join(", ", ProductExceptSelf(nums1))}]");

        int[] nums2 = {-1, 1, 0, -3, 3};
        Console.WriteLine($"Example 2: [{string.Join(", ", ProductExceptSelf(nums2))}]");
    }
}
