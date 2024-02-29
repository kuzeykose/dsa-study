class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        frq = {}
        ans = []

        for num in nums:
            if num in frq:
                frq[num] += 1
            else:
                frq[num] = 1
        
        sorted_frq = sorted(frq.items(), key=lambda item: item[1], reverse=True)

        for i in range(k):
            ans.append(sorted_frq[i][0])
        return ans
        