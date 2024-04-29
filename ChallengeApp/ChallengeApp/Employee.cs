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


        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Avg = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avg += grade;
            }

            statistics.Avg /= this.grades.Count;


            return statistics;
        }

    }
}
