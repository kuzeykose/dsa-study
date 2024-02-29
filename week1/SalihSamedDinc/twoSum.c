int* twoSum(int* nums, int numsSize, int target, int* returnSize) {
    int* indices = (int*)malloc(2 * sizeof(int));
    *returnSize = 2;
    int  i = 0;
    int j = 0;
    while (i < numsSize)
    {
        j = i + 1;
        while (j < numsSize)
        {
            if (nums[i] + nums[j] == target)
            {
                indices[0] = i;
                indices[1] = j;
                return indices;
            }
            j++;
        }
        i++;
    }

}
