using System;
using System.Collections.Generic;

char [] input = Console.ReadLine().ToCharArray();
SortedDictionary<char, int> characters = new();

for (int i = 0; i < input.Length; i++)
{
	if (!characters.ContainsKey(input[i]))
	{
		characters.Add(input[i], 0);
	}
	characters[input[i]]++;
}

foreach (var character in characters)
{
	char givenChar = character.Key;
	int count = character.Value;

    Console.WriteLine($"{givenChar}: {count} time/s");
}