class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        count = dict()
        for number in nums:
            count[f"{number}"] = count.get(f"{number}", 0) + 1
        for value in count.values():
            if value > 1:
                return True
                break
        return False