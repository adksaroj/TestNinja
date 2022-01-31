using NUnit.Framework;
using TestNinja.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _dpCalculator;

        [SetUp]
        public void SetupTests()
        {
            _dpCalculator = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(-5)]
        [TestCase(400)]
        public void CalculateDemeritPoints_WhenSpeedOutOfRange_ShouldThrowArgumentOutOfRangeException(int speed)
        {
            Assert.That(() => _dpCalculator.CalculateDemeritPoints(speed), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(0,0)]
        [TestCase(64,0)]
        [TestCase(65,0)]
        [TestCase(70,1)]
        [TestCase(76,2)]
        public void CalculateDemeritPoints_WhenSpeedInRange_ShouldReturnDemaritPoints(int speed, int expectedValue)
        {
            var result = _dpCalculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(expectedValue));
        }
    }
}