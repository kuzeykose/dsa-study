using System;

public class ValidParantheses
{
    public bool IsValid(string s)
    {
        Stack<char> stk = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stk.Push(c);
            }
            else if (c == ')' && (stk.Count == 0 || stk.Pop() != '('))
            {
                return false;
            }
            else if (c == ']' && (stk.Count == 0 || stk.Pop() != '['))
            {
                return false;
            }
            else if (c == '}' && (stk.Count == 0 || stk.Pop() != '{'))
            {
                return false;
            }

        }
        return stk.Count == 0;
    }

    public bool IsValid(string s)
    {
        Stack<char> stack = new();

        Dictionary<char, char> dict = new(){
            {'(', ')'},
            {'{', '}'},
            {'[', ']'}
        };

        for (int i = 0; i < s.Length; i++)
        {
            if (dict.Keys.Contains(s[i]))
                stack.Push(s[i]);
            else if (stack.Count > 0 && s[i] == dict[stack.Peek()])
                stack.Pop();
            else
                return false;
        }
        return stack.Count == 0;
    }
}
