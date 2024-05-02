using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        [Test]
        public void CombineNames_InputFirstAndLastName_ReturnGreetAndFullName()
        {
            //Arrange
            var customer = new Customer();

            //Act
            string fullPhrase = customer.GreetCombineNames("Antonio", "Dias");

            //Assert
            Assert.That(fullPhrase, Is.EqualTo("Hello, Antonio Dias"));
        }
    }
}
