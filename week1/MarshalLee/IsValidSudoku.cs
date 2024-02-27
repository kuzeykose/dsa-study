public bool IsValidSudoku(char[][] board)
{
    HashSet<(int, int)> rows = new();
    HashSet<(int, int)> columns = new();
    HashSet<(int, int, int)> subBoxes = new();

    for (int ri = 0; ri < 9; ri++)
    {
        for (int ci = 0; ci < 9; ci++)
        {
            if (board[ri][ci] == '.')
                continue;

            if (!rows.Add((ri, board[ri][ci])) ||
                !columns.Add((ci, board[ri][ci])) ||
                !subBoxes.Add((ri / 3, ci / 3, board[ri][ci])))
                return false;
        }
    }
    return true;
}