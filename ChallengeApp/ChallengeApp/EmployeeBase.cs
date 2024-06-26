﻿namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public static string version = "Dzien#18";

        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;
       
        protected EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public abstract void AddGrade(float grade);       
       
        public abstract void AddGrade(string grade);

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(long grade);

        public abstract void AddGrade(decimal grade);

        public abstract Statistics GetStatistics();
    }
}
