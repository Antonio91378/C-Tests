using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class GradingCalculatorNUnitTests
    {
        private GradingCalculator _gradingCalculator;

        [SetUp]
        public void SetUp()
        {
            _gradingCalculator = new GradingCalculator();
        }

        [Test]
        [TestCase(95,90, ExpectedResult = "A")]
        [TestCase(85,90, ExpectedResult = "B")]
        [TestCase(65,90, ExpectedResult = "C")]
        [TestCase(95,65, ExpectedResult = "B")]
        public string GradingChecker_InputScoreAndAttendance_GetCorrectGrade(int score, int attendance)
        {
            //Arrange
            _gradingCalculator.AttendancePercentage = attendance;
            _gradingCalculator.Score = score;

            //Act
            var result = _gradingCalculator.GetGrade();

            //Assert

            return result;
        }
    }
}
