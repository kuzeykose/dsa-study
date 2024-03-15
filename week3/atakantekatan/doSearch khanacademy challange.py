def doSearch(array, target):
    l, r = 0, len(array)
    
    while l <= r:
        
        mid = (l+r) // 2
        
        if target > array[mid]:
            l = mid + 1
        elif target < array[mid]:
            r = mid - 1
        elif target == array[mid]:
            return mid
    return -1
    
    
    
primes = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97]
result = doSearch(primes, 73)
print(result)
result2 = doSearch(primes, 72)
print(result2)