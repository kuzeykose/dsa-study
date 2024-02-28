class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        sorted_s = sorted(s)
        sorted_t = sorted(t)
        return sorted_s == sorted_t


class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        counts = defaultdict(int)

        for ch in s:
            counts[ch] += 1
        for ch in t:
            counts[ch] -= 1
        
        for val in counts.values():
            if val != 0:
                return False
        
        return True