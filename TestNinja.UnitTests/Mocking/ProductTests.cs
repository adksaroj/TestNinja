using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void GetPrice_IsGoldCustomer_Apply30PercentDiscount()
        {
            var customer = new Customer { IsGold = true };
            var result = new Product{ ListPrice = 100 }.GetPrice(customer);
            Assert.That(result, Is.EqualTo(70));
        }
    }
}
