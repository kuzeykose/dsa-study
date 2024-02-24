/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number[]}
 */
var topKFrequent = function (nums, k) {
    let frequentObj = {};
    let maxHeap = new MaxPriorityQueue();
    let result = [];
  
    for (let num of nums) {
      if (frequentObj.hasOwnProperty(num)) {
        frequentObj[num]++;
      } else {
        frequentObj[num] = 1;
      }
    }
    for (let pair in frequentObj) {
      maxHeap.enqueue(pair, frequentObj[pair]);
    }
  
    for (let i = 0; i < k; i++) {
      result.push(maxHeap.dequeue().element);
    }
  
    return result;
  };