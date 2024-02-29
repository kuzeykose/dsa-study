class Solution(object):
    def topKFrequent(self, nums, k):
        freq_map = {}
        for num in nums:
            if num in freq_map:
                freq_map[num] += 1
            else:
                freq_map[num] = 1

        sorted_nums = sorted(freq_map.keys(), key=lambda x: freq_map[x], reverse=True)

        return sorted_nums[:k]

