class Solution:
    def isPalindrome(self, s: str) -> bool:
        for character in string.punctuation:
            s = s.replace(character, "")
        merged_s = s.lower().replace(" ","")
        return merged_s[::-1] == merged_s