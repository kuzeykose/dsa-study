class Solution:
    def maxArea(self, height: List[int]) -> int:
        left, right, maxArea = 0, len(height)-1, 0

        while left < right:
            currentArea = min(height[left], height[right]) * (right - left)
            maxArea = max(maxArea, currentArea)
            if height[left] < height[right]:
                left += 1
            else:
                right -= 1
        return maxArea