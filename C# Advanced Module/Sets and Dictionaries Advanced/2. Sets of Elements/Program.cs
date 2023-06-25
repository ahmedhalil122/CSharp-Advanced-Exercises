using System;
using System.Collections.Generic;
using System.Linq;

HashSet<int> firstSet=new HashSet<int>();
HashSet<int> secondSet=new HashSet<int>();

int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


for (int i = 0; i < input[0]; i++)
{
    firstSet.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < input[1]; i++)
{
    secondSet.Add(int.Parse(Console.ReadLine()));
}
HashSet<int> result = new HashSet<int>();
firstSet.IntersectWith(secondSet);


Console.WriteLine(string.Join(' ', firstSet));