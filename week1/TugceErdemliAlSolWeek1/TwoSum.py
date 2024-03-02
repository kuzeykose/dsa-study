class Solution(object):
    def twoSum(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[int]
        """

        num_indices = {}
        for i, num in enumerate(nums):
            complement = target - num
            if complement in num_indices:
                return ([num_indices[complement], i])
            num_indices[num] = i
