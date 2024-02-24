class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        dct = {}
        for w in strs:
            word = "".join(sorted(w))
            if word not in dct:
                dct.update({word:[w]})
            else:
                dct[word].append(w)
        ans = []
        for l in dct:
            ans.append(dct[l])
        return ans