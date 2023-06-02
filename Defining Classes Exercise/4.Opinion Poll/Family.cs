
namespace DefiningClasses;

public class Family
{
    private List<Person> members = new();

    public Family()
    {
        members = new List<Person>();
    }

    private int myVar;

    public int Members
    {
        get { return this.myVar; }
        set { myVar = value; }
    }


    public void AddMember(Person person)
    {
       members.Add(person);
    }

    public Person GetOldestMember()
    {
        return this.members.MaxBy(x => x.Age);
    }

}
