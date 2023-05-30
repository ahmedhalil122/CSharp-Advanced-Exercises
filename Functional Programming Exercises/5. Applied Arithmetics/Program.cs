
using System;
using System.Collections.Generic;
using System.Linq;

Action<List<int>> print = numbers => Console.WriteLine(string.Join(" ", numbers));

Func<string, List<int>, List<int>> operation = (command, numbers) =>
{
    List<int> result = new();

    foreach (var number in numbers)
    {
        switch (command)
        {
            case "add":
                result.Add(number + 1);
                break;
            case "subtract":
                result.Add(number - 1);
                break;
            case "multiply":
                result.Add(number * 2);
                break;
        }
    }

    return result;
};



List<int> inputNumbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(x=>int.Parse(x))
    .ToList();

string cmd = string.Empty;
while ((cmd = Console.ReadLine()) != "end")
{
    if (cmd == "print")
    {
        print(inputNumbers);
    }
    else
    {
        inputNumbers = operation(cmd, inputNumbers);
    }
}