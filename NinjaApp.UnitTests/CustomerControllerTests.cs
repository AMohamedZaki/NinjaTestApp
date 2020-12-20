using NUnit.Framework;
using TestNinja.Fundamentals;

namespace NinjaApp.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private CustomerController _customerController;
        [SetUp]
        public void Setup()
        {
            _customerController = new CustomerController();
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnedNotFound()
        {
            var result = _customerController.GetCustomer(0);

            // Assert The class type only
            Assert.That(result, Is.TypeOf<NotFound>());

            // Assert the class type or one of its derivatives
            // Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnedOk()
        {
            var result = _customerController.GetCustomer(1);

            // Assert The class type only
            Assert.That(result, Is.TypeOf<Ok>());
        }

    }
}
