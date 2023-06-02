
namespace DefiningClasses;

public class Family
{
    private List<Person> members = new();

    public Family()
    {
        members = new List<Person>();
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
