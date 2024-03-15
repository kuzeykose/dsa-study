class Solution:
    def findMin(self, nums: List[int]) -> int:
        l, r = 0, len(nums)-1
        m = float("inf")
        while l <= r:
            mid = (l+r) // 2
            m = min(m, nums[mid])
            
            if nums[mid] > nums[r]:
                if nums[l] < nums[r]:
                    r = mid - 1
                else:
                    l = mid + 1
            else:
                r = mid - 1
        return m