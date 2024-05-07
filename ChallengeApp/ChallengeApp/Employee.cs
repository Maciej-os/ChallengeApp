namespace ChallengeApp
{
    public class Employee : Person
    {
        public static string version = "Dzien#12";

        private List<float> grades = new List<float>();

        public Employee()
           : this("No Name")
        {

        }

        public Employee(string name)
            : this(name, "No Surname")
        {
            
        }

        public Employee(string name, string surname )
            : base(name, surname, '?')   
        {
            
        }

        public Employee(string name, string surname, char sex)
            : base(name, surname, sex)
        {

        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }

            else
            {
                throw new Exception("Invalid grade value");
            }

        }

        public void AddGrade(string grade)
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

        public void AddGrade(char grade)
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
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Avg += grade;
                }
            }

            statistics.Avg /= this.grades.Count;

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
