using Moq;
using Sparky;

namespace SparkyNUnitTest;

[TestFixture]
public class ProductNUnitTest
{
    [Test]
    public void GetProductPrice_PlatinumCustomer_ReturnPriceDiscounted()
    {
        var mockCustumer = new Mock<ICustomer>();
        mockCustumer.Setup(_ => _.IsPlatinum).Returns(true);
        var product = new Product(1, "any", 50);
        var result = product.GetPrice(mockCustumer.Object);
        Assert.That(result, Is.EqualTo(40));
    }
}
