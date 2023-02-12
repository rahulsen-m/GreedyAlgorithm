int MinimumNumberOfJumps(int[] arr)
{
    int jumps = 0, current = 0, highest = 0;
    if (arr[0] <= 0)
        return -1;
    for (int i = 0; i < arr.Length -1; i++)
    {
        highest = Math.Max(highest, arr[i] + i);
        if (i == current)
        {
            current = highest;
            jumps++;
        }
    }
    return jumps;
}

int[] jumpeArray = new int[] { 1, 4, 3, 2, 6, 7 };
Console.WriteLine(MinimumNumberOfJumps(jumpeArray));
Console.Read();