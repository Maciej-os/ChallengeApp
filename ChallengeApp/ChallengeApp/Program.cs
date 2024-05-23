using ChallengeApp;

Console.WriteLine("Witaj w programie dla pracowników!");
Console.WriteLine("__________________________________");
Console.WriteLine();

Console.WriteLine("Podaj imię pracownika: ");
var name = Console.ReadLine();

Console.WriteLine("Podaj nazwisko pracownika: ");
var surname = Console.ReadLine();

//var employee01 = new EmployeeInFile(name, surname);
var employee01 = new EmployeeInMemory(name, surname);

employee01.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

while (true)
{
    Console.WriteLine($"Podaj kolejną ocenę dla {name} {surname} :");

    var input = Console.ReadLine();

    if (input == "q" || input == "Q")
    {
        break;
    }

    try
    {
        employee01.AddGrade(input);
    }

    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }

}

var statistic01 = employee01.GetStatistics();

Console.WriteLine($"Wyniki dla pracownika {name} {surname} poniżej");
Console.WriteLine();
Console.WriteLine($"Średnia: {statistic01.Avg:N2}");
Console.WriteLine($"Min: {statistic01.Min}");
Console.WriteLine($"Max: {statistic01.Max}");
Console.WriteLine($"Ocena: {statistic01.AvgLetter}");