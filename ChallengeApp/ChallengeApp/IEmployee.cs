namespace ChallengeApp
{
    internal interface IEmployee
    {
        void AddGrade(float grade);

        void AddGrade(string grade);

        void AddGrade(char grade);

        void AddGrade(double grade);

        void AddGrade(long grade);

        void AddGrade(decimal grade);

        Statistics GetStatistics();

        string Name { get;  }

        string Surname { get;  }

        char Sex { get;  }
    }
}