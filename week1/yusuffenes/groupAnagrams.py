def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
    stDict=dict()
    for i in strs:
        sortedW = "".join(sorted(i))
        if  sortedW not in stDict.keys():
            stDict[sortedW] = [i]
        else:
            stDict[sortedW].append(i)           
    print(sortedW)
    return list(stDict.values())
    