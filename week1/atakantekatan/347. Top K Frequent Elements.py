class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        ans = []
        cnt = collections.Counter(nums)
        dct = sorted(cnt.items(), key=lambda x: x[1], reverse=True)
        for i in range(k):
            ans.append(dct[i][0])
        return ans