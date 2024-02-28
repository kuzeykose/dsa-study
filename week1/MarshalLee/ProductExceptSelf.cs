//Attempt 1: Doesn't work when all of the elements in the input are the same
public int[] ProductExceptSelf(int[] nums)
{
    List<int> answer = new List<int>();

    foreach (int i in nums)
    {
        List<int> list = new List<int> { i };
        var remainingElements = nums.Except(list);

        int product = 1;
        foreach (int element in remainingElements)
        {
            product *= element;
        }

        answer.Add(product);
    }
    return answer.ToArray();
}



//Model answer, should be studied later
public int[] ProductExceptSelf(int[] nums)
{
    var input = nums.AsSpan();
    var length = nums.Length;
    var lastIndex = length - 1;

    // Result span with ones

    Span<int> result = stackalloc int[length];
    result.Fill(1);

    // Fill result, each element is left side * right side of nums
    // Complete when left reach end of nums and right reach start

    for (int i = 0, left = 1, right = 1; i < length; i++)
    {

        // Left to right movement

        result[i] *= left;
        left *= input[i];

        // Right to left movement

        result[lastIndex - i] *= right;
        right *= input[lastIndex - i];
    }

    // Copy result span (in stack memory) to input (in heap)
    // So we may not to create a new array on the heap memory

    result.CopyTo(input);
    return nums;
}