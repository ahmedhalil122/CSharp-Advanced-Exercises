using System;
using System.Collections.Generic;
using System.Linq;

int[] input = Console.ReadLine().Split().Select(x=>int.Parse(x)).ToArray();
string cmd = Console.ReadLine();
List<int> numbers = new();

for (int i = input[0]; i <= input[input.Length-1]; i++)
{
    numbers.Add(i);
}
if (cmd == "odd")
{
    Predicate<int> isOdd = IsOdd;
    foreach (var x in numbers)
    {
        if (isOdd(x))
        {
            Console.Write($"{x} ");
        }
    }
}
else if (cmd == "even")
{
    Predicate<int> isEven = IsEven;
    foreach (var x in numbers)
    {
        if (isEven(x))
        {
            Console.Write($"{x} ");
        }
    }
}

static bool IsEven(int x) =>  x % 2 == 0;
static bool IsOdd(int x) => x%2 != 0;