/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    let dp = new Map()
    
    for(let i = 0; i < nums.length; i++) {
        let value = dp.get(target-nums[i])
        if(value !== undefined && i != value) return [value,i]
        dp.set(nums[i],i)
    }
    
    return []
};
