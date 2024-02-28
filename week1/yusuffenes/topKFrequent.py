from collections import Counter

def topKFrequent(self, nums: List[int], k: int) -> List[int]:
    returnedList = []
    for x in Counter(nums).most_common(k):
        returnedList.append(x[0])
    return returnedList