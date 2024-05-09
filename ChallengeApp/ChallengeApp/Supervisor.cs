namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public char Sex { get; set; }

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

            switch (grade)
            {
                case "6":
                    AddGrade(100);
                    break;

                case "6-":
                case "-6":
                    AddGrade(95);
                    break;

                case "5+":
                case "+5":
                    AddGrade(85);
                    break;

                case "5":
                    AddGrade(80);
                    break;

                case "5-":
                case "-5":
                    AddGrade(75);
                    break;

                case "4+":
                case "+4":
                    AddGrade(65);
                    break;

                case "4":
                    AddGrade(60);
                    break;

                case "4-":
                case "-4":
                    AddGrade(55);
                    break;

                case "3+":
                case "+3":
                    AddGrade(45);
                    break;

                case "3":
                    AddGrade(40);
                    break;

                case "3-":
                case "-3":
                    AddGrade(45);
                    break;

                case "2+":
                case "+2":
                    AddGrade(25);
                    break;

                case "2":
                    AddGrade(20);
                    break;

                case "2-":
                case "-2":
                    AddGrade(25);
                    break;

                case "1+":
                case "+1":
                    AddGrade(5);
                    break;

                case "1":
                case "1-":
                case "-1":
                    AddGrade(0);
                    break;
                default:
                    throw new Exception("Mark should be between 6(max)...4+...3-... 1(min)");
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
