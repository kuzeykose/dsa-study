import re
class Solution(object):
    def isPalindrome(self, s):
        """
        :type s: str
        :rtype: bool
        """
        s = s.lower()
        s = re.sub(r'[^a-z0-9]', '', s)
        pal_s = s[::-1]
        if s == pal_s:
            return True
        else:
            return False