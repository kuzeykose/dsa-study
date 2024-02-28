class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        snums = nums.copy()
        snums.sort()
        left = 0
        right = len(nums)-1
        while snums[left]+snums[right] != target:
            right -= 1
            if snums[left]+snums[right]<target:
                right += 1
                left += 1
        ans = []
        for i in range(len(nums)):
            if nums[i] == snums[left] or nums[i] == snums[right]:
                ans.append(i)
        return ans