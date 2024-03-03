public class Solution
{
    public bool IsPalindrome(string s)
    {
        s = s.ToLower();
        char[] arr = s.ToCharArray();
        arr = Array.FindAll<char>(arr, (c => (char.IsLetterOrDigit(c))));
        s = new string(arr);
        for (int i = 0; i < s.Length; i++)
        {
            if (!(s[i] == s[s.Length - 1 - i]))
            {
                return false;
            }
        }
        return true;
    }
}