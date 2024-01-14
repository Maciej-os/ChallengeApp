using ChallengeApp;

Employee user1 = new Employee("Adam", "Kowal", 18);
Employee user2 = new Employee("Zuzia", "Nowak", 23);
Employee user3 = new Employee("Monika", "Myk", 44);


Console.WriteLine(user1.Name + " " + user1.Surname + " " + user1.Age);
Console.WriteLine(user2.Name + " " + user2.Surname + " " + user2.Age);
Console.WriteLine(user3.Name + " " + user3.Surname + " " + user3.Age);


user1.AddScore(1);
user1.AddScore(1);
user1.AddScore(1);
user1.AddScore(1);
user1.AddScore(1);

user2.AddScore(2);
user2.AddScore(2);
user2.AddScore(2);
user2.AddScore(2);
user2.AddScore(2);

user3.AddScore(3);
user3.AddScore(3);
user3.AddScore(3);
user3.AddScore(3);
user3.AddScore(3);

if ((user3.Result >= user2.Result) && (user3.Result >= user1.Result))
{
    Console.WriteLine(user3.Name + " " + user3.Result);
}

if ((user2.Result >= user1.Result) && (user2.Result >= user3.Result))
{
    Console.WriteLine(user2.Name + " " + user2.Result);
}

if ((user1.Result >= user2.Result) && (user1.Result >= user3.Result))
{
    Console.WriteLine(user1.Name + " " + user1.Result);
}

