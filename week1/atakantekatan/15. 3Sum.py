class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        nums.sort()
        ans = []
        for i in range(len(nums)-2):
            if i>0 and nums[i] == nums[i-1]:
                continue
            left = i+1
            right = len(nums)-1
            if nums[i]>0:
                break
            while left<right:
                SUM = nums[i] + nums[left] + nums[right]
                if SUM < 0:
                    left += 1
                elif SUM >0:
                    right -= 1
                else:
                    LIST = [nums[i],nums[left],nums[right]]
                    ans.append(LIST)
                    while left<right and nums[left]==LIST[1]:
                        left += 1
                    while left<right and nums[right]==LIST[2]:
                        right -= 1
        return ans