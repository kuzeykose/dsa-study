class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        sortedList = list()
        sortedList2 = list()
        for string in strs:
            sortedString = sorted(string)
            myTuple = (sortedString,strs.index(string))
            sortedList.append(myTuple)
        sortedList.sort()
        allList = list()
        listCount = 0
        for i in range(0, len(sortedList)):
            if (sortedList[i][0] == sortedList[i-1][0]) & (i > 0):
                allList[listCount-1].append(strs[sortedList[i][1]])
            else:
                allList.append([strs[sortedList[i][1]]])
                listCount += 1

        return allList

