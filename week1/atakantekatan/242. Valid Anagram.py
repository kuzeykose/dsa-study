class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False
        cnts = collections.Counter(s)
        cntt = collections.Counter(t)
        for letter in cnts:
            if cnts[letter] != cntt[letter]:
                return False
        return True