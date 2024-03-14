class Solution:
    def search(self, nums: List[int], target: int) -> int:
        low = 0
        high = len(nums) - 1
        med = int((low + high) / 2)
        while True:
            med = int((low + high) / 2)
            if nums[med] > target:
                high = med - 1
                med = int((low + high) / 2)
            elif nums[med] < target:
                low = med + 1
                med = int((low + high) / 2)
            if nums[med] == target:
                return med
            if low == high or low > high: 
                return -1     