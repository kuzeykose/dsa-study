class Solution(object):
    def minWindow(self, s, t):
        if not s or not t:
            return ""
        t_count = {}
        s_count = {}
        for char in t:
            t_count[char] = t_count.get(char, 0) + 1
        min_length = float('inf')
        min_start = 0
        min_end = 0
        left = 0
        right = 0
        while right < len(s):
            s_count[s[right]] = s_count.get(s[right], 0) + 1
            while self.contains_all_chars(s_count, t_count) and left <= right:
                current_length = right - left + 1
                if current_length < min_length:
                    min_length = current_length
                    min_start = left
                    min_end = right
                s_count[s[left]] -= 1
                left += 1
            right += 1
        if min_length == float('inf'):
            return ""
        return s[min_start:min_end+1]
    def contains_all_chars(self, s_count, t_count):
        for char, count in t_count.items():
            if char not in s_count or s_count[char] < count:
                return False
        return True
