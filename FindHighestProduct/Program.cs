int FindHeighestMuliplication(List<int> arr)
{
    // first need to short
    arr = arr.OrderBy(x => x).ToList();
    int length = arr.Count-1;
    // take highest 3
    int highest1 = arr[length] * arr[length-1] * arr[length-2];
    int highest2 = arr[0] * arr[1] * arr[length];
    return Math.Max(highest1, highest2);
}

List<int> products = new List<int>{ 0,-1,10,5,7 };
Console.WriteLine(FindHeighestMuliplication(products));
Console.Read();