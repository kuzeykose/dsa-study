class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        count = 0
        max_count = 0
        seen = set(nums)
        n = len(seen)
        for x in seen:
            if x-1 in seen: continue
            org = x
            while x in seen:
                x += 1
            max_count = x-org if x-org > max_count else max_count
            if max_count == n:
                return max_count
        return max_count  

         