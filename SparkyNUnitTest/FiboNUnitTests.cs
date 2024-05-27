using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class FiboNUnitTests
    {
        private Fibo _fibonattiGenerator;

        [SetUp]
        public void SetUp()
        {
            _fibonattiGenerator = new Fibo();
        }

        [Test]
        public void FibonattiSeriesGen_InputRangeOf1_GetFiboNumbers()
        {
            //Arrange
            _fibonattiGenerator.Range = 1;

            //Act
            var result = _fibonattiGenerator.GetFiboSeries();

            //Assert
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.Ordered.Ascending);
            Assert.That(result, Is.EquivalentTo(new List<int>{0}));
        }

        [Test]
        public void FibonattiSeriesGen_InputRangeOf6_GetFiboNumbers()
        {
            //Arrange
            _fibonattiGenerator.Range = 6;

            //Act
            var result = _fibonattiGenerator.GetFiboSeries();

            //Assert
            Assert.That(result, Does.Contain(3));
            Assert.That(result.Count, Is.EqualTo(6));
            Assert.That(result, Does.Not.Contain(4));
            Assert.That(result, Is.EquivalentTo(new List<int> { 0, 1, 1, 2, 3, 5 }));
        }
    }
}
