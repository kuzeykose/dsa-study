class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        num_map = {}
        
        for i in range(len(nums)):
            diff = target - nums[i]
            if diff in num_map:
                return [num_map[diff], i]
            num_map[nums[i]] = i