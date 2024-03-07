class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        word = ""
        ans = 0
        for letter in s:
            if letter not in word:
                word += letter
            else:
                ans = max(ans,len(word))
                while letter in word:
                    word = word[1:]
                word += letter
        return max(ans,len(word))