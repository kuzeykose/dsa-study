def isPalindrome(self, s: str) -> bool:
    ls = s.lower()
    print(ls)
    n=len(ls)
    nan=[]
    for i in range(n):
        if ls[i].isalnum():
            nan.append(ls[i])
    ms =""
    ms = ms.join(nan)
    if ms[::-1] == ms:
        return True
    else:
        return False       