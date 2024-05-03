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
            Assert.Multiple(() =>
            {
                Assert.That(fullPhrase, Is.EqualTo("Hello, Antonio Dias"));
                Assert.That(fullPhrase, Does.Contain(","));
                Assert.That(fullPhrase, Does.Contain("antonio").IgnoreCase);
                Assert.That(fullPhrase, Does.StartWith("Hello,"));
                Assert.That(fullPhrase, Does.EndWith("Dias"));
                //using regex
                Assert.That(fullPhrase, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]"));
            });
        }

        [Test]
        public void GreetMessage_NotGreeted_ReturnsNull()
        {
            //arrange

            //act

            //assert
            Assert.IsNull(_customer.GreetMessage);
        }

        [Test]
        public void DiscountCheck_DefaultCustomer_ReturnsDiscountInRange()
        {
            int result = _customer.Discount;
            Assert.That(result, Is.InRange(10, 25));
        }
        
        [Test]
        public void GreetMessage_EmptyFirstName_ThrowsException()
        {
            //Checking the exception details
            var exceptionDetails = Assert.Throws<ArgumentException>(() =>
            { _customer.GreetCombineNames("", "Dias"); });
            Assert.That(exceptionDetails.Message , Is.EqualTo("First Name empty"));

            //Checking if the exception is being thrown
            Assert.Throws<ArgumentException>(() => { _customer.GreetCombineNames("", "Dias"); });
            Assert.That(() => _customer.GreetCombineNames("", "Dias"), Throws.ArgumentException);
        }
        
        [Test]
        public void CustomerType_CreateCustomerWithLessThan100Order_ReturnBasicCustomer()
        {
            _customer.OrderTotal = 10;
            var result = _customer.GetCustomerDetails();
            Assert.That(result, Is.TypeOf<BasicCustomer>());
        }
        
        [Test]
        public void CustomerType_CreateCustomerWithMoreThan100Order_ReturnPlatinumCustomer()
        {
            _customer.OrderTotal = 101;
            var result = _customer.GetCustomerDetails();
            Assert.That(result, Is.TypeOf<PlatinumCustomer>());
        }



    }
}
