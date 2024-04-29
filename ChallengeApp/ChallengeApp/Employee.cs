using System;
using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        public static string Version = "Dzien#9";

        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;

        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }

            else 
            {
                Console.WriteLine("Invalid grade value");
            }

        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result)) 
            {
            this.AddGrade(result);
            }
            else 
            {
                Console.WriteLine("String is not float");
            }
        }

        public void AddGrade(double grade)
        {
            var value = (float)grade;
            this.AddGrade(value);                            
        }

        public void AddGrade(long grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }
        public void AddGrade(decimal grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();

            statistics.Avg = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            int index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Avg += this.grades[index];
                index++;
            }
            while (index < this.grades.Count);
                       
            statistics.Avg /= this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();

            statistics.Avg = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            int index = 0;

            while (index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Avg += this.grades[index];
                index++;
            }
            
            statistics.Avg /= this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();

            statistics.Avg = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int i = 0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Avg += this.grades[i];
            }
            
            statistics.Avg /= this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithForeach()
        {
            var statistics = new Statistics();

            statistics.Avg = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var item in this.grades) 
            {
                statistics.Max = Math.Max(statistics.Max, item);
                statistics.Min = Math.Min(statistics.Min, item);
                statistics.Avg += item;
            }

            statistics.Avg /= this.grades.Count;

            return statistics;
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Avg = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            int index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Avg += this.grades[index];
                index++;
            }
            while (index < this.grades.Count);
                       
            statistics.Avg /= this.grades.Count;

            return statistics;
        }

    }
}
