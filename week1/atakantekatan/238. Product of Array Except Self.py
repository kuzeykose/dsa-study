class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        prod = 1
        cnt = {}
        ans = []
        for n in nums:
            if n not in cnt:
                cnt.update({n:1})
            else:
                cnt[n] += 1
            if n!=0:
                prod *= n
        if 0 not in cnt:
            for num in nums:
                ans.append(prod//num)
        elif cnt[0]==1:
            for num in nums:
                if num == 0:
                    ans.append(prod)
                else:
                    ans.append(0)
        elif cnt[0]>1:
            ans = [0]*len(nums)
        return ans