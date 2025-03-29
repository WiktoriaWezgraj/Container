using Container;

var numberContainer = new Container<int>();

int[] numbersToTry = [ 1, 2, 3, 4, 5, 6 ];

foreach (var number in numbersToTry)
{
    if (numberContainer.TryAdd(number))
    {
        Console.WriteLine($"Successfully added {number}");
    }
    else
    {
        Console.WriteLine($"Container is full, cannot add {number}");
    }
}

Console.WriteLine("Adding 99 forcefully");
numberContainer.ForceAdd(99);

Console.WriteLine($"All numbers in the container: {string.Join(',', numberContainer.GetAll())}");
