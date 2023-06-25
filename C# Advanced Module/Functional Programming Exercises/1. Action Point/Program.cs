using System;

string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string[]> allNamesInNewLine = names => Console.WriteLine(string.Join(Environment.NewLine, names));

allNamesInNewLine(names);