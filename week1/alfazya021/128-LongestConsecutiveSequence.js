/**
 * @param {number[]} nums
 * @return {number}
 */
var longestConsecutive = function(nums) {
    let map = new Map()
    let max = 0
    
    for(let i = 0; i < nums.length; i++) {
        if(map.get(nums[i])) {
            continue;
        }
        
        let left = map.get(nums[i] - 1) ?? 0
        let right = map.get(nums[i] + 1) ?? 0
        let pointer = right + left + 1
        
        if(right + left + 1 > max) {
            max = right + left + 1
        }
  
        map.set(nums[i],pointer)
        map.set(nums[i] - left, pointer) 
        map.set(nums[i] + right, pointer)
    }
    
    return max
};