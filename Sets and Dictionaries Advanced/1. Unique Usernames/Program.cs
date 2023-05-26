HashSet<string> usernames = new HashSet<string>();

int userCount = int.Parse(Console.ReadLine());

for (int i = 0; i < userCount; i++)
{
    usernames.Add(Console.ReadLine());
}

foreach (string username in usernames)
{
    Console.WriteLine(username);
}