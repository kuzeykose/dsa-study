class Solution:
    def checkInclusion(self, s1: str, s2: str) -> bool:
        if len(s1)>len(s2):
            return False

        c1 = Counter()
        cw = Counter()
        l, r = 0, len(s1)

        for i in range(l,r):
            c1[s1[i]] += 1
            cw[s2[i]] += 1

        while r < len(s2) and c1 != cw:
            cw[s2[l]] -= 1
            if cw[s2[l]] == 0:
                del cw[s2[l]]
            cw[s2[r]] += 1
            l += 1
            r += 1
            
        return True if c1 == cw else False