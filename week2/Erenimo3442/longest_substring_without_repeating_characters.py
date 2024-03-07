class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        left = 0
        unique = set()
        answer = 0
        for right in range(len(s)):
            if s[right] not in unique:
                unique.add(s[right])
                answer = max(answer, right - left + 1)
            else:
                while s[right] in unique:
                    unique.remove(s[left])
                    left += 1
                unique.add(s[right])
        return answer