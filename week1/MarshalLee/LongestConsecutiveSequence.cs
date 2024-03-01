public int LongestConsecutive(int[] nums)
{
    if (nums.Length == 0)
        return 0;
    HashSet<int> hashSet = new(nums);
    int answer = 1;
    foreach (int number in hashSet)
    {
        if (hashSet.Contains(number - 1))
        {
            continue;
        }

        int counter = 1;
        while (hashSet.Contains(number + counter))
        {
            counter++;
        }

        answer = Math.Max(counter, answer);
    }

    return answer;
}