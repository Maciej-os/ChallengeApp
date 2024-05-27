﻿using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        void AddGrade(float grade);

        void AddGrade(string grade);

        void AddGrade(char grade);

        void AddGrade(double grade);

        void AddGrade(long grade);

        void AddGrade(decimal grade);
        
        event GradeAddedDelegate GradeAdded;

        Statistics GetStatistics();   


    }
}