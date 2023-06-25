using DefiningClasses;


namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            //Person person1 = new Person();
            //person1.Name = "Petar";
            //person1.Age = 20;

            //Person noNameDefaultAge = new();
            //Person noNameWithAge = new(25);
            //Person john = new("John", 32);

            Family family = new();
            int inputCount = int.Parse(Console.ReadLine());
            SortedDictionary<string, int> personsOver30 = new();
           
            for (int i = 0; i < inputCount; i++)
            {
                string[] membersInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new(membersInfo[0], int.Parse(membersInfo[1]));

                if (person.Age>30)
                {
                    personsOver30.Add(person.Name, person.Age);
                }
            }

            foreach (var person in personsOver30)
            {
                Console.WriteLine($"{person.Key} - {person.Value}");
            }
        }

    }
}

