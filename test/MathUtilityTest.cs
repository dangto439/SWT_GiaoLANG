using mathUtil;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace test
{
    public class MathUtilityTest
    {
        [Test]
        //test case 1: check isPrime() with n = 0
        // * expected rs: false
        public void TestIsPrimeWithNumber0ReturnWell()
        {
            // Arrange
            int number = 0;
            // Act
            bool result = MathUtility.IsPrime(number);

            // Assert
            Assert.IsFalse(result);
            //Assert.That(number, Is.False);
        }

        [Test]
        //test case 2: check isPrime() with n = 3
        // * expected rs: false
        public void TestIsPrimeWithNumber1ReturnWell()
        {
            // Arrange
            int number = 3;
            // Act
            bool result = MathUtility.IsPrime(number);

            // Assert
            Assert.IsTrue(result);
            //Assert.That(number, Is.isFalse);
        }

        [Test]
        //test case 3: check isPrime() with n = 0,1,2,3,4,5,6,7
        // * expected rs: true
        public void TestIsPrimeWithNumber235711ReturnWell()
        {
            int[] arr = [2, 3, 5, 7, 11];
            foreach (int i in arr)
            {
                Assert.IsTrue(MathUtility.IsPrime(i));
            }
        }

        [Test]
        //test case 4: check isPrime() with n = not a number
        // * expected rs: throw exception
        public void TestIsPrimeWithWrongNumberThrowException()
        {
            // Arrange
            var input = "notANumber";

            //assert
            Assert.Throws<FormatException>(() =>
            {
                int number = int.Parse(input); // This will throw a FormatException
                MathUtility.IsPrime(number); // This line won't be reached due to the exception
            });
        }
    }
}