using System;
using System.Linq;

int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int[,] matrix = new int[input[0], input[1]];

for (int row = 0; row < input[0]; row++)
{
    int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int col = 0; col < input[1]; col++)
    {
        matrix[row, col] = numbers[col];
    }
}

int maxValue = int.MinValue;
int currentRow = 0;
int currentCol = 0;
    int sum = 0;

for (int row = 0;row < matrix.GetLength(0)-2; row++)
{
    for (int col = 0; col < matrix.GetLength(1)-2; col++)
    {
        sum = 0;
        sum+= matrix[row, col]; //0-0
        sum+= matrix[row, col+1];//0-1
        sum+= matrix[row, col+2];//0-2
        sum+= matrix[row+1, col];//1-0
        sum+= matrix[row+1, col+1];//1-1
        sum+= matrix[row+1, col+2];//1-2
        sum+= matrix[row+2, col];//2-0
        sum+= matrix[row+2, col+1];//2-1
        sum+= matrix[row+2, col+2];//2-2
        if (sum>maxValue)
        {
            maxValue = sum;
            currentRow = row;
            currentCol = col;
        }
    }
}
Console.WriteLine($"Sum = {maxValue}");
Console.WriteLine($"{matrix[currentRow,currentCol]} {matrix[currentRow, currentCol+1]} {matrix[currentRow, currentCol+2]}");
Console.WriteLine($"{matrix[currentRow+1,currentCol]} {matrix[currentRow+1, currentCol+1]} {matrix[currentRow+1, currentCol+2]}");
Console.WriteLine($"{matrix[currentRow+2,currentCol]} {matrix[currentRow+2, currentCol+1]} {matrix[currentRow+2, currentCol+2]}");