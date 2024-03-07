using System;

public class MinStack
{
    public class MinStack
    {

        private readonly Stack<KeyValuePair<int, int>> Stack = new();

        public MinStack()
        {
        }

        public void Push(int val)
        {
            int min = Stack.Count == 0 ? val : Math.Min(Stack.Peek().Value, val);

            Stack.Push(new KeyValuePair<int, int>(val, min));
        }

        public void Pop()
        {
            Stack.Pop();
        }

        public int Top()
        {
            return Stack.Peek().Key;
        }

        public int GetMin()
        {
            return Stack.Peek().Value;
        }
    }
}
