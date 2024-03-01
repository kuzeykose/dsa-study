using System;

public class Class1
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        Stack<int> stack = new();
        int[] array = new int[temperatures.Length];
        for (int i = temperatures.Length - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && temperatures[stack.Peek()] <= temperatures[i])
                stack.Pop();
            if (stack.Count > 0)
                array[i] = stack.Peek() - i;
            stack.Push(i);
        }
        return array;
        //Dictionary<int, int> dict = new();
        //int j = 0;
        //for (int i = 0; i <= temperatures.Length - 1; i++)
        //{
        //    dict.Add(temperatures[i], 0);
        //    while (j < i)
        //    {
        //        if (dict.ElementAt(j).Key < temperatures[i])
        //        {
        //            dict[temperatures[j]] = i - j;
        //            j++;
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //}

        //return dict.Values.ToArray();
    }
}
