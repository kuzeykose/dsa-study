class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        cnt = collections.Counter(nums)
        for num in cnt:
            if cnt[num]>=2:
                return True
        return False