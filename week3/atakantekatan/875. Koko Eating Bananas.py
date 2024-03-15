#LeetCode explanation
class Solution:
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        piles.sort()
        mintime = float("inf")
        l, r = 1, piles[-1]
        while l <= r:
            time = 0
            mid = (l+r) // 2
            for ban in piles:
                time += math.ceil(ban/mid)
            if time > h:
                l = mid + 1
            elif time < h:
                r = mid - 1
                mintime = min(mintime, mid) if mintime != float("inf") else mid
            elif time == h:
                mintime = min(mintime, mid)
                r = mid - 1
        return mintime