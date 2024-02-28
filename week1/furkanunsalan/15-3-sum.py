class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        nums.sort()
        target = 0
        output = set()
        
        for i in range(len(nums)):
            j = i + 1
            k = len(nums) - 1
            while j < k:
                s = nums[i] + nums[j] + nums[k]
                if s == target:
                    output.add((nums[i], nums[j], nums[k]))
                    j += 1
                    k -= 1
                elif s < target:
                    j += 1
                else: # s is higher than target
                    k -= 1
        return output

        