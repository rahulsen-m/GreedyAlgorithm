List<int> SwapPermutation(List<int> arr, int k)
{
    for (int i = 0; i < arr.Count - 1; i++)
    {
        if (k > 0)
        {
            int maxValueIndex = i;
            for (int j = i + 1; j < arr.Count; j++)
            {
                if (arr[j] > arr[maxValueIndex])
                    maxValueIndex = j;
            }
            // we need to swap the position with max value
            if (maxValueIndex != i)
            {
                int temp = arr[maxValueIndex];
                arr[maxValueIndex] = arr[i];
                arr[i] = temp;
                k--;
            }

        }
        else break;
    }
    return arr;
}

List<int> element = new List<int>() { 8, 2, 7, 4, 5, 6, 3, 1 };
var result = HighestSwapPermutation(element, 2);
result.ForEach(x =>
{
    Console.Write(x + " ");
});
Console.Read();
List<int> HighestSwapPermutation(List<int> arr, int k)
{
    //lexicographically array : means the highest element is the length of the array
    // this will set the height value. Which will be last element of the array/list
    int maxValue = arr.Count, i =0, key = 0;
    // convert the list to dictionary. As each key will keep the value of the array
    var dic = arr.Select(p => new { key = key++, value = p })
                .ToDictionary(x => x.key, x => x.value);
    while(k > 0 && i < arr.Count)
    {
        // setting max value in a variable
        var maxValueIndex = dic.FirstOrDefault(x => x.Value == maxValue).Key;
        if (i == maxValueIndex)
        {
            i++;
            maxValue--; continue;
        }
        else
        {
            int temp = arr[maxValueIndex];
            arr[maxValueIndex] = arr[i];
            arr[i] = temp;
            
            // update the dictionary
            temp = dic[i];
            dic[i] = maxValue;
            dic[maxValueIndex] = temp;
            // decrease swap count
            k--;
        }
        i++;
        maxValue--;
    }
    return arr;
}
