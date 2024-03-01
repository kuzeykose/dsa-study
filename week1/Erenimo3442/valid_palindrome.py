import re 

class Solution:
    def isPalindrome(self, s: str) -> bool:
        s = s.lower()
        for str in s:
            if re.search('[^a-zA-Z0-9]', str):
                s = s.replace(str, '')
        if s[::-1] == s:
            return True