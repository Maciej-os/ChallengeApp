using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public static string version = "Dzien#16";

        private string fileName = "grades_V02.txt";

        public EmployeeInFile(string name, string surname) : base(name, surname)
        {

        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }

            else
            {
                throw new Exception("Invalid grade value");
            }

        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                if (grade.Length == 1)
                {
                    AddGrade((char)grade[0]);
                }
                else
                {
                    throw new Exception("String is not float");
                }


            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public override void AddGrade(double grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        public override void AddGrade(long grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }
        public override void AddGrade(decimal grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            if (File.Exists(fileName))
            {
                statistics.Avg = 0;
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;
                int lineCounter = 0;
                int lineException = 0;

                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        lineCounter++;
                        if (float.TryParse(line, out float number))
                        {
                            if (number >= 0)
                            {
                                if (number > 100)
                                {
                                    lineException++;
                                    Console.WriteLine($"Line nr {lineCounter} was omitted : number is too high");
                                }
                                else
                                {
                                    statistics.Max = Math.Max(statistics.Max, number);
                                    statistics.Min = Math.Min(statistics.Min, number);
                                    statistics.Avg += number;
                                }
                            }

                        }
                        else

                        {
                            lineException++;
                            Console.WriteLine($"Line nr {lineCounter} was omitted : line does not contain number");
                        }
                        line = reader.ReadLine();

                    }

                    statistics.Avg /= (lineCounter - lineException);
                }
            }


            switch (statistics.Avg)
            {
                case var avg when avg >= 80:
                    statistics.AvgLetter = 'A';
                    break;
                case var avg when avg >= 60:
                    statistics.AvgLetter = 'B';
                    break;
                case var avg when avg >= 40:
                    statistics.AvgLetter = 'C';
                    break;
                case var avg when avg >= 20:
                    statistics.AvgLetter = 'D';
                    break;
                default:
                    statistics.AvgLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
