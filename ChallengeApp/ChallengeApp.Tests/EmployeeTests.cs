namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhenEmployeeCollectScores_ShouldReturnCorrectMin()
        {
            // arrange
            var employee = new Employee("Rafa³", "Kowalski");
            employee.AddGrade(15);
            employee.AddGrade(5);
            employee.AddGrade(5);
            employee.AddGrade(10);
            employee.AddGrade(1);

            //act

            var statisctisc = employee.GetStatistics();

            //asert
            Assert.AreEqual(1, statisctisc.Min);
        }

        [Test]
        public void WhenEmployeeCollectScores_ShouldReturnCorrectMax()
        {
            // arrange
            var employee = new Employee("Rafa³", "Kowalski");
            employee.AddGrade(15);
            employee.AddGrade(5);
            employee.AddGrade(5);
            employee.AddGrade(10);
            employee.AddGrade(1);

            //act

            var statisctisc = employee.GetStatistics();

            //asert
            Assert.AreEqual(15, statisctisc.Max);
        }

        [Test]
        public void WhenEmployeeCollectScores_ShouldReturnCorrectAvg()
        {
            // arrange
            var employee = new Employee("Rafa³", "Kowalski");
            employee.AddGrade(15);
            employee.AddGrade(5);
            employee.AddGrade(5);
            employee.AddGrade(10);
            employee.AddGrade(1);

            //act

            var statisctisc = employee.GetStatistics();

            //asert
            Assert.AreEqual(7, 2f, statisctisc.Avg);
        }

        [Test]
        public void WhenEmployeeCollectStrings_ShouldReturnCorrectAvg()
        {
            // arrange
            var employee = new Employee("Rafa³", "Kowalski");
            employee.AddGrade("15");
            employee.AddGrade("5");
            employee.AddGrade("5");
            employee.AddGrade("10");
            employee.AddGrade("1");

            //act

            var statisctisc = employee.GetStatistics();

            //asert
            Assert.AreEqual(7, 2f, statisctisc.Avg);
        }

        [Test]
        public void WhenEmployeeCollectLettersAsString_ShouldReturnCorrectAvg()
        {
            // arrange
            var employee = new Employee("Rafa³", "Kowalski");
            employee.AddGrade("A");
            employee.AddGrade("B");
            employee.AddGrade("C");


            //act

            var statisctisc = employee.GetStatistics();

            //asert
            Assert.AreEqual(80, statisctisc.Avg);
        }

        [Test]
        public void WhenEmployeeCollectLettersAsChar_ShouldReturnCorrectAvg()
        {
            // arrange
            var employee = new Employee("Rafa³", "Kowalski");
            employee.AddGrade('A');
            employee.AddGrade('B');
            employee.AddGrade('C');


            //act

            var statisctisc = employee.GetStatistics();

            //asert
            Assert.AreEqual(80, statisctisc.Avg);
        }
    }
}