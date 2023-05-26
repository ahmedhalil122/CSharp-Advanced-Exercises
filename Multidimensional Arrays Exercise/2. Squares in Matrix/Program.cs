using System;
using System.Linq;

int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

char[,] matrix = new char[input[0], input[1]];

int matches = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] characters = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = characters[col];
    }
}
for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col + 1] && matrix[row, col] == matrix[row + 1, col])
        {
            matches++;
        }
    }
}

Console.WriteLine(matches);



//int[] dimensions = Console.ReadLine()
//    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
//    .Select(int.Parse)
//    .ToArray();

//char[,] matrix = new char[dimensions[0], dimensions[1]];

//for (int row = 0; row < matrix.GetLength(0); row++)
//{
//    char[] chars = Console.ReadLine()
//        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
//        .Select(n => char.Parse(n))
//        .ToArray();

//    for (int col = 0; col < matrix.GetLength(1); col++)
//    {
//        matrix[row, col] = chars[col];
//    }
//}

//int count = 0;

//for (int row = 0; row < matrix.GetLength(0) - 1; row++)
//{
//    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
//    {
//        if (matrix[row, col] == matrix[row, col + 1]
//            && matrix[row, col] == matrix[row + 1, col + 1]
//            && matrix[row, col] == matrix[row + 1, col])
//        {
//            count++;
//        }
//    }
//}

//Console.WriteLine(count);