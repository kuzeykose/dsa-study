class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        letterCount_s = dict()
        letterCount_t = dict()

        for letter in s:
            letterCount_s[letter] = letterCount_s.get(letter, 0) + 1
        for letter in t:
            letterCount_t[letter] = letterCount_t.get(letter, 0) + 1
        
        if letterCount_s == letterCount_t:
            return True
