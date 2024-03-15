class Solution:
    def search(self, nums: List[int], target: int) -> int:
        l, r = 0, len(nums) - 1
        while l <= r:
            if nums[l] == target:
                return l
            elif nums[r] == target:
                return r
            
            mid = (l+r) // 2
            
            if target < nums[mid]:
                r = mid - 1
            elif target > nums[mid]:
                l = mid + 1
            elif target == nums[mid]:
                return mid
        return -1