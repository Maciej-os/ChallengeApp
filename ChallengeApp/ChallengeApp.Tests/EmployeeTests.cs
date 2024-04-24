namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        
        [Test]
        public void WhenEmployeeCollectScoresPlusOrMinus_ShouldReturnCorrectResult()
        {
            // arrange
            var employee = new Employee("Rafa³", "Kaczka12!", 34);
            employee.AddScore(5);
            employee.AddScore(5);
            employee.AddScore(5);
            employee.AddScore(-10);
            employee.AddScore(1);

            //act

            var result = employee.Result;

            //asert
            Assert.AreEqual(6, result);
        }
        [Test]
        public void WhenEmployeeCollectOnlyScoresMinus_ShouldReturnCorrectResult()
        {
            // arrange
            var employee = new Employee("Rafa³", "Kaczka12!", 34);
            employee.AddScore(-5);
            employee.AddScore(-5);
            employee.AddScore(-5);
            employee.AddScore(-10);
            employee.AddScore(-1);

            //act

            var result = employee.Result;

            //asert
            Assert.AreEqual(-26, result);
        }
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
    }
}