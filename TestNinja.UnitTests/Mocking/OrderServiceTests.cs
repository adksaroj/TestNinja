using Moq;
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
    public class OrderServiceTests
    {
        private OrderService _orderService;
        private Mock<IStorage> _storage;
        private Order _order;

        [SetUp] public void SetUp() 
        {
            _storage = new Mock<IStorage>();
            _order = new Order();
            _orderService = new OrderService(_storage.Object);
        }

        [Test]
        public void PlaceOrder_ShouldReturnOrderIdInt() 
        {
            _orderService.PlaceOrder(_order);
            _storage.Verify(s => s.Store(_order));
        }
    }
}
