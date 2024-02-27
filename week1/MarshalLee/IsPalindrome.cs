public bool IsPalindrome(string s)
{
    string lowerString = s.ToLower();
    int left = 0, right = lowerString.Length - 1;
    while (left < right)
    {
        if (!char.IsLetterOrDigit(lowerString[left]))
        {
            left++;
        }
        else if (!char.IsLetterOrDigit(lowerString[right]))
        {
            right--;
        }
        else
        {
            if (lowerString[left] != lowerString[right])
                return false;
            left++;
            right--;
        }
    }
    return true;
}