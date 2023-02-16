static int MinmumRequiredMeetingRoom(List<List<int>> A)
{
    int max = 0, current = 0;
    // create a list which will add +1 to the starting element of the array and -1 to the second element of the array
    var newList = new int[A.Count * 2][];
    int count = 0;
    foreach (var item in A)
    {
        newList[count] = new int[] { item[0], +1 };
        newList[count + 1] = new int[] { item[1], -1 };
        count += 2;
    }

    // sort the array
    newList = newList.OrderBy(x => x[0]).ToArray();

    //iterate and increase / decrease the max
    for (int i = 0; i < newList.Length; i++)
    {
        var val = newList[i][1];
        current += val;
        max = Math.Min(max, current);
    }
    return max;
}

List<List<int>> elements = new List<List<int>>()
{
    new List<int> { 17, 26 },
    new List<int> { 14, 22 },
    new List<int> { 7, 29 },
    new List<int> { 2, 29 },
    new List<int> { 11, 14 },
    new List<int> { 5, 24 },
    new List<int> { 1, 14 },
    new List<int> { 13, 14 }

//    new List<int> {1, 18},
//new List<int> {18, 23},
//new List<int> {15, 29},
//new List<int> {4, 15},
//new List<int> {2, 11},
//new List<int> {5, 13}
};

Console.WriteLine(MinmumRequiredMeetingRoom(elements));
Console.Read();


