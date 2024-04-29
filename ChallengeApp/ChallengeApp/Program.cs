﻿using ChallengeApp;


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
var statistics2 = employee2.GetStatistics();


Console.WriteLine($"Wyniki dla: {employee1.Name}");
Console.WriteLine($"Average: {statistics1.Avg:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

Console.WriteLine();

Console.WriteLine($"Wyniki dla: {employee2.Name}");
Console.WriteLine($"Average: {statistics2.Avg:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

//float f = 3.4999f;
//if ( (f - (int)f) >= .5)
//{
//    Console.WriteLine(Math.Ceiling(f));
//}
//else 
//{
//    Console.WriteLine(Math.Floor(f));
//}






