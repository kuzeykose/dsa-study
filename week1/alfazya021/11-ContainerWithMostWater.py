class Solution:
    def maxArea(self, height: List[int]) -> int:
        first = 0
        second = len(height) - 1
        max = 0
        while first != second:
            currentVolume = (second - first) * min(height[first], height[second])
            if currentVolume > max:
                max = currentVolume
            if height[first] > height[second]:
                second -= 1
            else:
                first += 1
        return max

        