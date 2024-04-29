using ChallengeApp;


var employee1 = new Employee("Adam", "Kowalski");
var employee2 = new Employee("Michał", "Mysło");

employee1.AddGrade("1000");
employee1.AddGrade("Aryay");
employee1.AddGrade(1000L);
employee1.AddGrade(2.22D);
employee1.AddGrade(2.23M);
employee1.AddGrade(1);
employee1.AddGrade(10);

employee2.AddGrade(1);
employee2.AddGrade(2);
employee2.AddGrade(4);

var statistics1 = employee1.GetStatistics();
//var statistics2 = employee2.GetStatistics();

var statistics01 = employee1.GetStatisticsWithDoWhile();
var statistics02 = employee1.GetStatisticsWithWhile();
var statistics03 = employee1.GetStatisticsWithFor();
var statistics04 = employee1.GetStatisticsWithForeach();

//Console.WriteLine($"Wyniki dla: {employee1.Name}");
//Console.WriteLine($"Average: {statistics1.Avg:N2}");
//Console.WriteLine($"Min: {statistics1.Min}");
//Console.WriteLine($"Max: {statistics1.Max}");

//Console.WriteLine();

//Console.WriteLine($"Wyniki dla: {employee2.Name}");
//Console.WriteLine($"Average: {statistics2.Avg:N2}");
//Console.WriteLine($"Min: {statistics2.Min}");
//Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine();

Console.WriteLine("                     Min         Max     Avg");
Console.WriteLine("{0,0} {1,14} {2,12} {3,9}", "()     ", statistics1.Min, statistics1.Max, statistics1.Avg);
Console.WriteLine("{0,0} {1,14} {2,12} {3,9}", "DoWhile", statistics01.Min, statistics01.Max, statistics01.Avg);
Console.WriteLine("{0,0} {1,14} {2,12} {3,9}", "While  ", statistics02.Min, statistics02.Max, statistics02.Avg);
Console.WriteLine("{0,0} {1,14} {2,12} {3,9}", "For    ", statistics03.Min, statistics03.Max, statistics03.Avg);
Console.WriteLine("{0,0} {1,14} {2,12} {3,9}", "Foreach", statistics04.Min, statistics04.Max, statistics04.Avg);







