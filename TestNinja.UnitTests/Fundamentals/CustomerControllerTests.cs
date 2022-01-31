using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class CustomerControllerTests
    {
        private CustomerController _customerController;

        [SetUp]
        public void Setup()
        {
            _customerController = new CustomerController();
        }

        [Test]
        public void GetCustomer_WhenIdIsZero_ShouldReturnNotFoundObject()
        {
            var result = _customerController.GetCustomer(0);

            //Assert
            Assert.That(result, Is.TypeOf<NotFound>()); //TypeOf - result is exactly of type NotFound
        }

        [Test]
        public void GetCustomer_WhenIdIsNonZero_ShouldReturnOkObject()
        {
            var result = _customerController.GetCustomer(1);

            //Assert
            //Assert.That(result, Is.InstanceOf<Ok>()); //InstanceOf - result is of type Ok
            // or Derivative(child object) of Ok
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
