using System;
using Date_Modifier;


internal class Program
{
    private static void Main(string[] args)
    {
        string startDate = Console.ReadLine();
        string endDate = Console.ReadLine();

        int difference = DateModifier.GetDifference(startDate, endDate);

        Console.WriteLine(difference);

    }
}