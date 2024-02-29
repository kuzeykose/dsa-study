"With neetcode explanation"
class Solution:
    def trap(self, height: List[int]) -> int:
        left,right = 0,len(height)-1
        maxleft,maxright = height[left],height[right]
        W = 0
        while left<right:
            if maxleft<=maxright:
                left += 1
                V = maxleft-height[left]
                if V>0:
                    W += V
                maxleft = max(maxleft,height[left])
            else:
                right -= 1
                V = maxright-height[right]
                if V>0:
                    W += V
                maxright = max(maxright,height[right])
        return W