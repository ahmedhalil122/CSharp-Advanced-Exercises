using System;
using System.Collections.Generic;

int count = int.Parse(Console.ReadLine());
SortedSet<string> elements = new();

for (int i = 0; i < count; i++)
{
    string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    foreach (string s in input)
    { 
        elements.Add(s); 
    }
    
}
Console.WriteLine(string.Join(' ', elements));