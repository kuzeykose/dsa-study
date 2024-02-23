#NOT MY SOLUTION
#SOLUTION LUNK: https://leetcode.com/problems/trapping-rain-water/discuss/4763050/My-Weird-Solution-or-Beats-94.98-of-users-in-Python3

class Solution:
    def trap(self, height: List[int]) -> int:
        trappedRain = []
        left, right = 0, len(height) - 1

        leftBoundary, rightBoundary = 0, 0
        while left < right:
            tempTrapped = 0

            while height[left] < leftBoundary or height[left] == 0:
                left += 1
            while height[right] < rightBoundary or height[right] == 0:
                right -= 1

            leftBoundary = height[left]
            rightBoundary = height[right]

            while height[left] >= height[right] and left != right:
                right -= 1

                if height[right] > rightBoundary:
                    rightBoundary = height[right]
                else:
                    tempTrapped += min(leftBoundary, rightBoundary) - height[right]

            while height[left] < height[right] and left != right:
                left += 1

                if height[left] > leftBoundary:
                    leftBoundary = height[left]
                else:
                    tempTrapped += min(leftBoundary, rightBoundary) - height[left]
            
            trappedRain.append(tempTrapped)
        return sum(trappedRain)