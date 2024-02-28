def twoSum(self, numbers: List[int], target: int) -> List[int]:
    nDict = dict()
    for i,n in enumerate(numbers):
        result = target-n
        if result in nDict:
            return[nDict[result],i]
        else:
            nDict[n] =i
    return []