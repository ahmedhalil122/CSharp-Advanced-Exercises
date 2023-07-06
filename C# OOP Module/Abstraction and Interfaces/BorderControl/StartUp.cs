using BorderControl.Models;
using BorderControl.Models.Interfaces;

string cmd;
List<IIdentifiable> identifiables = new();
while ((cmd=Console.ReadLine())!="End")
{
    string[] input = cmd.Split();
	if (input.Length==3)
	{
		IIdentifiable citizen = new Citizen(input[0], int.Parse(input[1]), input[2]);
		identifiables.Add(citizen);
	}
	else
	{
		IIdentifiable robot = new Robot(input[0], input[1]);
		identifiables.Add(robot);
	}	
}
string fakeId = Console.ReadLine();

foreach (var item in identifiables)
{
    if (item.Id.EndsWith(fakeId))
    {
        Console.WriteLine(item.Id);
    }
}