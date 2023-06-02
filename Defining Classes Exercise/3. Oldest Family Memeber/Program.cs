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
           
            for (int i = 0; i < inputCount; i++)
            {
                string[] membersInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new(membersInfo[0], int.Parse(membersInfo[1]));

                family.AddMember(person);
            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");


        }

    }
}

