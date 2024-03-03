class Solution(object):
    def containsDuplicate(self, nums):
        """
        :type nums: List[int]
        :rtype: bool
        """
        nodup = set(nums)
        if len(nums) == len(nodup):
            return False

        return True
