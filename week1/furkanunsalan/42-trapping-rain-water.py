class Solution:   
    def trap(self, h: List[int]) -> int:
        if not h: return 0

        l, r = 0, len(h) - 1
        leftMax, rightMax = h[l], h[r]
        res = 0

        while l < r:
            if leftMax < rightMax:
                l += 1
                leftMax = max(leftMax, h[l])
                res += leftMax - h[l]
            else:
                r -= 1
                rightMax = max(rightMax, h[r])
                res += rightMax - h[r]
        return res
