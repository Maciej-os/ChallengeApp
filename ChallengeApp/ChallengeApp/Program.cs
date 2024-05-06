using ChallengeApp;

Console.WriteLine("Witaj w programie dla pracowników!");
Console.WriteLine("__________________________________");
Console.WriteLine();


var employee01 = new Employee();

while (true) 
{
    Console.WriteLine("Podaj kolejną ocenę pracownika:");
    
    var input = Console.ReadLine();
    
    if (input == "q")
    {
        break;
    }

    try
    {
        employee01.AddGrade(input);
    }

    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
    
}

var statistic01 = employee01.GetStatistics();

Console.WriteLine("Wyniki dla pracownika poniżej");
Console.WriteLine();
Console.WriteLine($"Średnia: {statistic01.Avg:N2}");
Console.WriteLine($"Min: {statistic01.Min}");
Console.WriteLine($"Max: {statistic01.Max}");
Console.WriteLine($"Ocena: {statistic01.AvgLetter}");









