using System;
using System.Collections.Generic;
using System.Linq;

int inputCount = int.Parse(Console.ReadLine());
string[] chars = {" -> ", ","};

Dictionary<string, Dictionary<string, int>> wardrobe = new();

for (int i = 0; i < inputCount; i++)
{
    string [] input = Console.ReadLine().Split(chars,StringSplitOptions.RemoveEmptyEntries);
    string color = input[0];
    if (!wardrobe.ContainsKey(color))
    {
        wardrobe.Add(color, new Dictionary<string, int>());
    }
    for (int j = 1; j < input.Length; j++)
    {
        string currentDress = input[j];
        if (!wardrobe[color].ContainsKey(currentDress))
        {
            wardrobe[color].Add(currentDress, 0);
        }
        wardrobe[color][currentDress]++;
    }

}
string[] searchedDress = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

foreach (var dressColor in wardrobe)
{
    string colors = dressColor.Key;
    Console.WriteLine($"{colors} clothes:");
    foreach (var dressCountPair in dressColor.Value)
    {
        string print = $"* {dressCountPair.Key} - {dressCountPair.Value}";
        if (searchedDress[0] == dressColor.Key && searchedDress[1]==dressCountPair.Key)
        {
            print += " (found!)";
        }
        Console.WriteLine(print);
    }
}