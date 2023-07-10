using BorderControl.Models.Interfaces;

namespace BorderControl.Models
{
    public class Pet : INamable, IBirthable
    {
        public Pet(string name, string birhtdate)
        {
            Name = name;
            Birthdate = birhtdate;
        }
        public string Name { get; set; }
        public string Birthdate { get; set; }
    }
}
