
namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person person1 = new Person();
            person1.Name = "Petar";
            person1.Age = 20;
        }
    }
}

public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }


    public int Age
    {
        get { return age; }
        set { age = value; }
    }


}