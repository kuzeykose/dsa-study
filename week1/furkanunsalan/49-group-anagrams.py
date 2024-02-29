class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        ans = defaultdict(list)

        for word in strs:
            sorted_word = ''.join(sorted(word))
            ans[sorted_word].append(word)
        
        return list(ans.values())
        