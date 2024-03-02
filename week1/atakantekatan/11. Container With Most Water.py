"With Neetcode help"
class Solution:
    def maxArea(self, height: List[int]) -> int:
        Vmax = 0
        left = 0
        right = len(height)-1
        while left<right:
            V = min(height[left],height[right])*(right-left)
            Vmax = max(Vmax,V)
            if height[left]<height[right]:
                left += 1
            else:
                right -= 1
        return Vmax