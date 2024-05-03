using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        private Customer _customer;

        [SetUp] 
        public void SetUp()
        { 
            _customer = new Customer();
        }

        [Test]
        public void CombineNames_InputFirstAndLastName_ReturnGreetAndFullName()
        {
            //Arrange

            //Act
            string fullPhrase = _customer.GreetCombineNames("Antonio", "Dias");

            //Assert
            Assert.That(fullPhrase, Is.EqualTo("Hello, Antonio Dias"));
            Assert.That(fullPhrase, Does.Contain(","));
            Assert.That(fullPhrase, Does.Contain("antonio").IgnoreCase);
            Assert.That(fullPhrase, Does.StartWith("Hello,"));
            Assert.That(fullPhrase, Does.EndWith("Dias"));
            //using regex
            Assert.That(fullPhrase, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]"));
        }

        [Test]
        public void GreetMessage_NotGreeted_ReturnsNull()
        {
            //arrange

            //act

            //assert
            Assert.IsNull(_customer.GreetMessage);
        }
    }
}
