using System.Security.Cryptography.X509Certificates;

void MaxDisjointCount(List<List<int>> A)
{
    // shot the list by the 2nd element of the list
    for (int i = 0; i < A.Count; i++)
    {
        for (int j = 0; j < A.Count - 1; j++)
        {
            if (A[j][1] > A[j + 1][1])
            {
                var temp = A[j];
                A[j] = A[j + 1];
                A[j + 1] = temp;
            }
        }
    }
    // here count will be started from 1 as there should be at-least on disjoint set
    int count = 1, currentEndElement = A[0][1];
    for (int i = 1; i < A.Count; i++)
    {
        // check if the current end element is less then the next array's first element
        // we basically need the element which start point is grater then the previous array's last element
        // so that will not intersect 
        if (A[i][0] > currentEndElement)
        {
            currentEndElement= A[i][1];
            count++;
        }
    }
    Console.WriteLine($"Total number of disjoint element :  {count} ");
    Console.Read();
}


List<List<int>> elements = new List<List<int>>()
{
    new List<int> { 1,4 },
    new List<int> { 2,3 },
    new List<int> { 8,9 },
    new List<int> { 4,6 },
    
};

MaxDisjointCount(elements);
//BubbleSort();


void BubbleSort()
{
    int[] element = new int[] { 2, 8, 6, 3, 1, 10,0 };
    for (int i = 0; i < element.Length; i++)
    {
        for (int j = 0; j < element.Length - 1; j++)
        {
            if (element[j] > element[j+1])
            {
                var temp = element[j];
                element[j] = element[j+1];
                element[j+1] = temp;
            }
        }
    }
    foreach (var item in element)
    {
        Console.Write(item + " ");
    };
    Console.Read();
}