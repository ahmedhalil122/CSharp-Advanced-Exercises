using System;
using System.Linq;

int rows = int.Parse(Console.ReadLine());

int[][] array = new int[rows][];

for (int row = 0; row < rows; row++)
{
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        array[row] = new int[input.Length];
        array[row] = input;
    
}

for (int row = 0; row < rows-1; row++)
{
    for (int col = 0; col<array.Length; row++)
    {
        if (array.Length)
        {

        }
    }
}