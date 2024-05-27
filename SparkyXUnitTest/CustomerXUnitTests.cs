namespace Sparky
{
    public class CustomerXUnitTests
    {
        private readonly Customer customer;

        public CustomerXUnitTests()
        {
            customer = new Customer();
        }

        [Fact]
        public void CombineName_InputFirstAndLastName_ReturnFullName()
        {
            //Arrange

            //Act
            customer.GreetCombineNames("Ben", "Spark");
            Assert.Multiple(() =>
            {
                Assert.Equal("Hello, Ben Spark", customer.GreetMessage);
                Assert.StartsWith("Hello,", customer.GreetMessage);
                Assert.EndsWith("Spark", customer.GreetMessage);
                Assert.Matches("^Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+$", customer.GreetMessage);

            });
            //Assert

        }

        [Fact]
        public void GreetMessage_NotGreeted_ReturnsNull()
        {
            //arrange

            //act

            //assert
            Assert.Null(customer.GreetMessage);
        }

        [Fact]
        public void DiscountCheck_DefaultCustomer_ReturnsDiscountInRange()
        {
            int result = customer.Discount;
            Assert.InRange(result, 10, 25);
        }

        [Fact]
        public void GreetMessage_GreetedWithoutLastName_ReturnsNotNull()
        {
            // Arrange
            var customer = new Customer();

            // Act
            customer.GreetCombineNames("ben", "");

            // Assert
            Assert.NotNull(customer.GreetMessage);
            Assert.False(string.IsNullOrEmpty(customer.GreetMessage));
        }

        [Fact]
        public void GreetChecker_EmptyFirstName_ThrowsException()
        {
            // Arrange
            var customer = new Customer();

            // Act & Assert
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GreetCombineNames("", "Spark"));
            Assert.Equal("First Name empty", exceptionDetails.Message);

            Assert.Throws<ArgumentException>(() => customer.GreetCombineNames("", "spark"));
            var exception = Assert.Throws<ArgumentException>(() => customer.GreetCombineNames("", "spark"));
            Assert.Equal("First Name empty", exception.Message);
        }


        [Fact]
        public void CustomerType_CreateCustomerWithLessThan100Order_ReturnBasicCustomer()
        {
            // Arrange
            var customer = new Customer
            {
                OrderTotal = 10
            };

            // Act
            var result = customer.GetCustomerDetails();

            // Assert
            Assert.IsType<BasicCustomer>(result);
        }

        [Fact]
        public void CustomerType_CreateCustomerWithMoreThan100Order_ReturnPlatinumCustomer()
        {
            // Arrange
            var customer = new Customer
            {
                OrderTotal = 110
            };

            // Act
            var result = customer.GetCustomerDetails();

            // Assert
            Assert.IsType<PlatinumCustomer>(result);
        }
    }
}