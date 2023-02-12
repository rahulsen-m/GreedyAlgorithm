long Cost(int[] arr)
{
    long cost = 0;
	for (int i = 0; i < arr.Length; i++)
	{
        // if the bulb is on and the cost is even then bulb is on 
        if (arr[i] == 1 && cost % 2 == 0) continue;

        // if the bulb is on and the cost is odd then the bulb is off. We need to press the switch
        if (arr[i] == 1 && cost % 2 != 0) cost++;

        // if the bulb is off and the cost is odd then the bulb is on 
        if (arr[i] == 0 && cost % 2 != 0) continue;

        // if the bulb is off and the current state is even then the bulb is off.  We need to press the switch
        if (arr[i] == 0 && cost % 2 == 0) cost++;
    }
    return cost;
}

int[] bulb = new []{ 1, 0, 0, 0, 0 };
var bulb2 = new List<int> { 0,1,0,1};    
Console.WriteLine($"Cost will be = {bulbs(bulb2)}");
Console.Read();


int bulbs(List<int> A)
{
    var cost = 0;
    foreach (var needToOn in A)
    {
        // if the bulb is on and the cost is even then bulb is on 
        if (needToOn == 1 && cost % 2 == 0) continue;

        // if the bulb is on and the cost is odd then the bulb is off. We need to press the switch
        if (needToOn == 1 && cost % 2 != 0) cost++;

        // if the bulb is off and the cost is odd then the bulb is on 
        if (needToOn == 0 && cost % 2 != 0) continue;

        // if the bulb is off and the current state is even then the bulb is off.  We need to press the switch
        if (needToOn == 0 && cost % 2 == 0) cost++;
    }
    return cost;
}