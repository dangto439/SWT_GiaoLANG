using mathUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class MathUtilityDDTest
    {
        // Data for the test cases
        private static readonly object[] PrimeTestCases =
        {
            new object[] { 0, false },
            new object[] { 1, false },
            new object[] { 2, true },
            new object[] { 3, true },
            new object[] { 4, false },
            new object[] { 5, true },
            new object[] { 6, false },
            new object[] { 7, true },
            new object[] { 11, true }
        };


        [Test, TestCaseSource(nameof(PrimeTestCases))]
        public void TestIsPrime(int number, bool expectedResult)
        {
            // Act
            bool result = MathUtility.IsPrime(number);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
