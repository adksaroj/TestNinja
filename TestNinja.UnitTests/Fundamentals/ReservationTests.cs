using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User{ IsAdmin = true });

            //Asset
            //Assert.IsTrue(result);
            Assert.That(result, Is.True); //Supported by NUnit
            //Assert.That(result == true); //Supported by NUnit
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();
            var user = new User { IsAdmin = false };
            reservation.MadeBy = user;

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Asset
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation { MadeBy = new User()};

            //Act
            var result = reservation.CanBeCancelledBy(new User());

            //Asset
            Assert.IsFalse(result);
        }
    }
}
