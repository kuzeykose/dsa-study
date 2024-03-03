class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        nums.sort()
        ans = 0
        LIST = []

        for i in range(len(nums)):
            if LIST==[]:
                LIST.append(nums[i])
            elif nums[i] == nums[i-1] + 1:
                LIST.append(nums[i])
            elif nums[i] in LIST:
                continue
            else:
                ans = max(ans,len(LIST))
                LIST = [nums[i]]
        return max(ans,len(LIST))