using DefiningClasses;


namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person person1 = new Person();
            person1.Name = "Petar";
            person1.Age = 20;

            Person noNameDefaultAge = new();
            Person noNameWithAge = new(25);
            Person john = new("John", 32);

        }

    }
}

