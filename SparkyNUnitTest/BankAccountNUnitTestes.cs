using Moq;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class BankAccountNUnitTestes
    {
        private BankAccount bankAccount;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BankDeposit_Add100_ReturnTrue()
        {
            var logMock = new Mock<ILogBook>();
            var bankAccount = new BankAccount(logMock.Object);

            var result = bankAccount.Deposit(100);
            Assert.IsTrue(result);
            Assert.That(bankAccount.Balance, Is.EqualTo(100));
        }
    }
}
