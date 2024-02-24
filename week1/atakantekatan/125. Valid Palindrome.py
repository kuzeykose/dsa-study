class Solution:
    def isPalindrome(self, s: str) -> bool:
        alphabet = string.ascii_lowercase
        digits = string.digits
        s = s.lower()
        word = ""
        for letter in s:
            if letter in alphabet or letter in digits:
                word += letter
        if word[::-1] == word:
            return True
        return False