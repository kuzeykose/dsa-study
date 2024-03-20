def search(self, nums: List[int], target: int) -> int:
    min,flg,max=0,0,len(nums)-1
    while min<=max:
        m=int((min+max)//2)
        if nums[m]==target:
            flg=1
            return m
            break
        elif nums[m]<target:
            min=m+1
        else:
             max=m-1
    if flg == 0:
          return -1