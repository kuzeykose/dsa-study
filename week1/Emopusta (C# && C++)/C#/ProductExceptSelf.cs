public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        result[0] = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = result[i-1]*nums[i - 1];
        }

        int right = 1;

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= right;
            right *= nums[i];
        }
        return result;
    }
}

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int temp = 1;
        int zeroIndex = -1;
        int[] result = new int[nums.Length];

        for (int i = 0; i<nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                if(zeroIndex!=-1){
                    for(int j=0;j<nums.Length;j++){ result[j] = 0;}
                    return result;
                }
                zeroIndex = i;
                continue;
            }
            temp *= nums[i];
        }
        
        if (zeroIndex == -1)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i>0)
                {
                    temp *= nums[i - 1];
                }
                temp /= nums[i];
                result[i] = temp;
            }
            return result;
        }
        else
        {
            for(int i = 0;i<nums.Length; i++)
            {
                result[i] = 0;
            }
            result[zeroIndex] = temp;
            return result;
        }

    }
}