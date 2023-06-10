using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodIntegers;

internal class Program
{
    static void Main(string[] args)
    {
      int inputCount = int.Parse(Console.ReadLine());
        List<int> elements = new();
        for (int i = 0; i < inputCount; i++)
        {
            int input = int.Parse(Console.ReadLine());
            elements.Add(input);
        }

        int [] indicies = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Swap<int>(indicies[0], indicies[1], elements);

        foreach (var element in elements)
        {
            Console.WriteLine($"{typeof(Int32)}: {element}");
        }
    }


    

    static void Swap<T>(int index1, int index2, List<int> elements)
    {
        int temp = elements[index1];
        elements[index1] = elements[index2];
        elements[index2] = temp;
    }
}