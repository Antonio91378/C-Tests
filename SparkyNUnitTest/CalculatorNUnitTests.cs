using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }


        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange

            //Act
            int result = _calculator.AddNumbers(10, 20);

            //Assert
            Assert.That(result, Is.EqualTo(30));
            
        }
        
        [Test]
        public void OddChecker_InputNumber_GetBooleanVerification()
        {
            //Arrange

            //Act
            bool trueOddNumber = _calculator.IsOddNumber(1);
            bool falseOddNumber = _calculator.IsOddNumber(2);

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

            //Act
            bool isOddNumber = _calculator.IsOddNumber(a);

            //Assert
            return isOddNumber;
        }

        [Test]
        [TestCase(5.4, 10.5)] //15.9
        [TestCase(5.43, 10.53)] //15.96
        [TestCase(5.49, 10.59)] //16.08
        public void AddNumbersDouble_InputTwoDouble_GetCorrectAddition(double a, double b)
        {
            //Arrange

            //Act
            double result = _calculator.AddNumbersDouble(a, b);

            //Assert
            Assert.AreEqual(15.9, result,1);

        }

        [Test]
        public void OddRanger_InputMinAndMaxRange_RetunsOddNumbersInsideRange()
        {
            List<int> expectedOddRange = new() { 5, 7, 9 }; //5-10

            List<int> result = _calculator.GetOddRange(5, 10);

            Assert.That(result, Is.EquivalentTo(expectedOddRange));
            Assert.Contains(7, result);
            Assert.That(result, Does.Contain(7));
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result, Has.No.Member(6));
            Assert.That(result, Is.Ordered.Ascending);
            Assert.That(result, Is.Unique);
        }

    }

}