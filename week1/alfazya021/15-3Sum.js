var threeSum = function (a) {
  let answer = [];
  let nums = a;

  nums.sort(function (a, b) {
    return a - b;
  });

  for (let i = 0; i < nums.length - 2; i++) {
    if (i == 0 || (i > 0 && nums[i] != nums[i - 1])) {
      let low = i + 1;
      let high = nums.length - 1;
      let sum = 0 - nums[i];

      while (low < high) {
        let x = [nums[i], nums[low], nums[high]];

        if (nums[low] + nums[high] === sum) {
          answer.push(x);

          while (low < high && nums[low] == nums[low + 1]) low++;
          while (low < high && nums[high] == nums[high - 1]) high--;

          low++;
          high--;
        } else if (nums[low] + nums[high] > sum) {
          high--;
        } else {
          low++;
        }
      }
    }
  }

  return answer;
};
