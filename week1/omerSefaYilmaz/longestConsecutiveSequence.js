/**
 * @param {number[]} nums
 * @return {number}
 */
var longestConsecutive = function (nums) {
    if (nums.length === 0) return 0;
  
    const numsSet = new Set(nums);
    let longestStreak = 0;
  
    for (const num of numsSet) {
      if (!numsSet.has(num - 1)) {
        let currentNum = num;
        let currentStreak = 1;
  
        while (numsSet.has(currentNum + 1)) {
          currentNum += 1;
          currentStreak += 1;
        }
  
        longestStreak = Math.max(longestStreak, currentStreak);
      }
    }
  
    return longestStreak;
  };