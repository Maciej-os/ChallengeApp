
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void DifferentIntsWithTheSameValue_ShouldBeTheSame()
        {
            // arrange
            int number1 = 5;
            int number2 = 5;

            //act


            //asert

            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void DifferentFloatsWithTheSameValue_ShouldBeTheSame()
        {
            // arrange
            float number1 = 5.43f;
            float number2 = 5.43f;
            

            //act


            //asert

            Assert.AreEqual(number1, number2);
        }


        [Test]
        public void DifferentDoublesWithTheSameValue_ShouldBeTheSame()
        {
            // arrange
            double number1 = 5.43;
            double number2 = 5.43;


            //act


            //asert

            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void DoubleAndFloatWithTheSameValue_ShouldNotBeTheSame()
        {
            // arrange
            float number1 = 5.43f;
            double number2 = 5.43;


            //act


            //asert

            Assert.AreNotEqual(number1, number2);
        }


        [Test]
        public void DifferentStringsWithTheSameSigns_ShouldBeTheSameCausedByImmutable()
        {
            // arrange
            string number1 = "Adam";
            string number2 = "Adam";

            //act


            //asert

            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            // arrange
            var employee1 = GetEmployee("Adam");
            var employee2 = GetEmployee("Adam");

            //act


            //asert

            Assert.AreNotEqual(employee1, employee2);
        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
