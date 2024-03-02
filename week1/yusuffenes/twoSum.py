def twoSum(self, nums: List[int], target: int) -> List[int]:
    returnedList = []
    for i in range(nums.__len__()-1):
        for x in range(i+1,nums.__len__()):
            if nums[i] + nums[x] == target and returnedList.__len__() == 0:
                returnedList.append(i)
                returnedList.append(x)
    return returnedList