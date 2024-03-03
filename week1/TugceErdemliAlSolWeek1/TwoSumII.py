class Solution(object):
    def twoSum(self, numbers, target):
        """
        :type numbers: List[int]
        :type target: int
        :rtype: List[int]
        """
        num_indices = {}  # Rakamların indekslerini saklayacak bir sözlük
        for i, num in enumerate(numbers):
            complement = target - num
            if complement in num_indices:  # Eşleşen sayı önceden görülmüş mü?
                return [num_indices[complement] + 1, i + 1]  # İndeksleri döndür
            num_indices[num] = i  # Rakamı ve indeksi sakla
        return []
