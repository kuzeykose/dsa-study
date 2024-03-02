class Solution(object):
    def groupAnagrams(self, strs):
        """
        :type strs: List[str]
        :rtype: List[List[str]]
        """

        strs_dict = {}
        result_list = []

        for char in strs:
            sorted_str = ''.join(sorted(char))
            if sorted_str not in strs_dict:
                strs_dict[sorted_str] = [char]
            else:
                strs_dict[sorted_str].append(char)
        result_list.extend(strs_dict.values())
        return result_list