class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        low = 0
        high = len(numbers) - 1
        while True:
            middle = (low + high) // 2
            sum = numbers[low] + numbers[high]
            if sum == target:
                return [low + 1, high + 1]
            elif sum < target:
                if numbers[high] + numbers[middle] < target:
                    low = middle + 1
                else:
                    low += 1
            elif sum > target:
                if numbers[low] + numbers[middle] > target:
                    high = middle - 1
                else:
                    high -= 1
