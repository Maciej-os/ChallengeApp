namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public char Sex { get; set; }
    }
}
