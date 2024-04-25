namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        
        [Test]
        public void WhenEmployeeCollectScoresPlusOrMinus_ShouldReturnCorrectMin()
        {
            // arrange
            var employee = new Employee("Rafa³", "Kowalski");
            employee.AddGrade(15);
            employee.AddGrade(5);
            employee.AddGrade(5);
            employee.AddGrade(-10);
            employee.AddGrade(1);

            //act

            var statisctisc = employee.GetStatistics();

                        //asert
            Assert.AreEqual(-10, statisctisc.Min);
        }
        
        [Test]
        public void WhenEmployeeCollectScoresPlusOrMin_ShouldReturnCorrectMax()
        {
            // arrange
            var employee = new Employee("Rafa³", "Kowalski");
            employee.AddGrade(15);
            employee.AddGrade(5);
            employee.AddGrade(5);
            employee.AddGrade(-10);
            employee.AddGrade(1);

            //act

            var statisctisc = employee.GetStatistics();

            //asert
            Assert.AreEqual(15, statisctisc.Max);
        }

        [Test]
        public void WhenEmployeeCollectScoresPlusOrMinus_ShouldReturnCorrectAvg()
        {
            // arrange
            var employee = new Employee("Rafa³", "Kowalski");
            employee.AddGrade(15);
            employee.AddGrade(5);
            employee.AddGrade(5);
            employee.AddGrade(-10);
            employee.AddGrade(1);

            //act

            var statisctisc = employee.GetStatistics();

            //asert
            Assert.AreEqual(3.2f, statisctisc.Avg);
        }

        /*
        [Test]
        public void WhenEmployeeCollectOnlyScoresPlus_ShouldReturnCorrectResult()
        {
            // arrange
            var employee = new Employee("Rafa³", "Kaczka12!", 34);
            employee.AddScore(5);
            employee.AddScore(5);
            employee.AddScore(5);
            employee.AddScore(10);
            employee.AddScore(1);

            //act

            var result = employee.Result;

            //asert
            Assert.AreEqual(26, result);
        }
        */
    }
}