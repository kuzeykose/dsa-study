class Solution:

    def encode(self, strs: List[str]) -> str:
        if not strs:
            return -1
        elif len(strs)==1 and strs[0]=="":
            return ""
        s = ""
        for i in range(len(strs)):
            if i != len(strs)-1:
                s += strs[i] + "/app/"
            else:
                s += strs[i]
        return s
    def decode(self, s: str) -> List[str]:
        if s==-1:
            return []
        elif len(s)>0:
            return s.split("/app/")
        else:
            return [""]