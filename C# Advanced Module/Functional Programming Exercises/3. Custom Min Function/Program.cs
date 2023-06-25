using System;
using System.Linq;

int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

Func<int[], int> printSmallestNumber = numbers =>
{
        int minValue = int.MaxValue;
    foreach (var number in numbers)
    {
        if (number<minValue)
        {
            minValue = number;
        }
    }

   return minValue;
};

Console.WriteLine(printSmallestNumber(numbers));