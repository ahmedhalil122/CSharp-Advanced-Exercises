string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string, string[]> action = (title, names) =>
{
    foreach (string name in names)
    {
        Console.WriteLine($"{title} {name}");
        
    }
};



action("Sir", names);