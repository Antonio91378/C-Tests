using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    { 
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calc = new();

            //Act
            int result = calc.AddNumbers(10, 20);
            bool trulyOddNumber = calc.IsOddNumber(1);
            bool falseOddNumber = calc.IsOddNumber(2);

            //Assert
            Assert.That(result, Is.EqualTo(30));
            
        }
        
        [Test]
        public void OddChecker_InputNumber_GetBooleanVerification()
        {
            //Arrange
            Calculator calc = new();

            //Act
            bool trueOddNumber = calc.IsOddNumber(1);
            bool falseOddNumber = calc.IsOddNumber(2);

            //Assert
            Assert.IsTrue(trueOddNumber);
            Assert.IsFalse(falseOddNumber);
        }

        [Test]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        public bool OddChecker_InputNumber_GetBooleanVerification2(int a)
        {
            //Arrange
            Calculator calc = new();

            //Act
            bool isOddNumber = calc.IsOddNumber(a);

            //Assert
            return isOddNumber;
        }

    }

}