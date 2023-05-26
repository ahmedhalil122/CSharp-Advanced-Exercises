using System;
using System.Linq;

int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];

for (int row = 0; row < size; row++)
{
	int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
	for (int col = 0; col < size; col++)
	{
        matrix[row,col] = numbers[col];
	}   
}

int primaryDiagonalSum = 0;
int secondaryDiagonalSum = 0;

for (int i = 0; i < size; i++)
{
	primaryDiagonalSum+= matrix[i,i];
	secondaryDiagonalSum+= matrix[size-i-1,i];
}

Console.WriteLine($"{Math.Abs(primaryDiagonalSum-secondaryDiagonalSum)}");