public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> character = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            character.Push(s[i]);
            IsCompleted(character);
        }
        return (character.Count == 0);
    }

    public void IsCompleted(Stack<char> chars)
    {
        if (chars == null || chars.Count == 1)
        {
            return;
        }
        char cClose = chars.Pop();
        char cOpen;
        int top = chars.Count - 1;
        switch (cClose)
        {
            case ')':
                cOpen = chars.Pop();
                if (cOpen == '(')
                {
                    break;
                }
                chars.Push(cOpen);
                chars.Push(cClose);
                break;

            case '}':
                cOpen = chars.Pop();
                if (cOpen == '{')
                {
                    break;
                }
                chars.Push(cOpen);
                chars.Push(cClose);
                break;
            case ']':
                cOpen = chars.Pop();
                if (cOpen == '[')
                {
                    break;
                }
                chars.Push(cOpen);
                chars.Push(cClose);
                break;
            default:
                chars.Push(cClose);
                break;
        }
    }
}
