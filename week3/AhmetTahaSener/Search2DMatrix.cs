public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        HashSet<int> numbers = new HashSet<int>();

        foreach (int[] i in matrix)
        {
            foreach (int j in i)
            {
                numbers.Add(j);
            }
        }

        if (numbers.Contains(target))
        {
            return true;
        }
        return false;
    }
}