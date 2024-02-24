def containsDuplicate(self, nums: List[int]) -> bool:
    nums.sort()
    if len(nums)>1:
        for i in range(len(nums)):
            if i<len(nums)-1:
                if nums[i] == nums[i+1]:
                    return True
            else:
                return False
    else:
        return False
