using System;
using System.Collections.Generic;
using System.Linq;

int inputCount = int.Parse(Console.ReadLine());

Dictionary<int, int> numbers = new();

for (int i = 0; i < inputCount; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (!numbers.ContainsKey(number))
    {
        numbers.Add(number, 0);
    }
    numbers[number]++;

}

Console.WriteLine(numbers.Single(x=> x.Value%2==0).Key);