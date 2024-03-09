using System;

public class EvaluateReversePolishNotation
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new();

        foreach (string token in tokens)
        {
            if (token == "+" || token == "-" || token == "*" || token == "/")
            {
                int secondOperand = stack.Pop();
                int firstOperand = stack.Pop();
                int result = token switch
                {
                    "+" => firstOperand + secondOperand,
                    "-" => firstOperand - secondOperand,
                    "*" => firstOperand * secondOperand,
                    "/" => firstOperand / secondOperand,
                    _ => throw new InvalidOperationException($"Unexpected token: {nameof(token)}")
                };
                stack.Push(result);
            }
            else
            {
                stack.Push(int.Parse(token));
            }
        }

        return stack.Pop();
    }
}
