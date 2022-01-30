using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnsSumOfTwoArguments()
        {
            //Arrange
            var math = new Fundamentals.Math();
            //Assert
            var result = math.Add(5,7);
            //Act
            Assert.That(result, Is.EqualTo(5 + 7));
        }

        [Test]
        public void Max_WhenFirstArgumentIsGreater_ReturnsTheFirstArgument()
        {
            //Arrange
            var math = new Fundamentals.Math();
            //Assert
            var result = math.Max(7, 5);
            //Act
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Max_WhenSecondArgumentIsGreater_ReturnsTheSecondArgument()
        {
            //Arrange
            var math = new Fundamentals.Math();
            //Assert
            var result = math.Max(5, 8);
            //Act
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Max_WhenBothArgsEqual_ReturnsTheSameArgument()
        {
            //Arrange
            var math = new Fundamentals.Math();
            //Assert
            var result = math.Max(3, 3);
            //Act
            Assert.That(result, Is.EqualTo(3));
        }
    }
}
