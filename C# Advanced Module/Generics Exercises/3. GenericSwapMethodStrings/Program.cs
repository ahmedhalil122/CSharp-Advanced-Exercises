using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings;

internal class Program
{
    static void Main(string[] args)
    {
      int inputCount = int.Parse(Console.ReadLine());
        List<string> elements = new();
        for (int i = 0; i < inputCount; i++)
        {
            string input = Console.ReadLine();
            elements.Add(input);
        }

        int [] indicies = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Swap<string>(indicies[0], indicies[1], elements);

        foreach (var element in elements)
        {
            Console.WriteLine($"{typeof(string)}: {element}");
        }
    }


    

    static void Swap<T>(int index1, int index2, List<string> elements)
    {
        string temp = elements[index1];
        elements[index1] = elements[index2];
        elements[index2] = temp;
    }
}