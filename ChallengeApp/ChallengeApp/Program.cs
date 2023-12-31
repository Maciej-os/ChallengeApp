string name = "Ewa";
bool woman = true;
byte age = 31;


if (woman)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (name == "Ewa" && age == 30)
    {
        Console.WriteLine("Ewa, lat 30");
    }
    else
    {
        Console.WriteLine("Brak klasyfikacji");
    }
}
else
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else
    {
        Console.WriteLine("Brak klasyfikacji");
    }

}

