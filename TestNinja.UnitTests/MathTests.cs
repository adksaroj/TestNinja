using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Fundamentals.Math _math;

        //Setup and Teardown - Used to do some task before/after each test
        //Teardown is used mainly in integration scenarios where we want to do some cleanup 
        //like deleting records from database

        [SetUp]
        public void Setup()
        {
            _math = new Fundamentals.Math(); //executes for each test
        }

        [Test]
        public void Add_WhenCalled_ReturnsSumOfTwoArguments()
        {
            //Arrange
            //var math = new Fundamentals.Math();
            
            //Assert
            var result = _math.Add(5,7);
            
            //Act
            Assert.That(result, Is.EqualTo(5 + 7));
        }

        [Test]
        public void Max_WhenFirstArgumentIsGreater_ReturnsTheFirstArgument()
        {
            //Arrange
            //var math = new Fundamentals.Math();
            
            //Assert
            var result = _math.Max(7, 5);
            
            //Act
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Max_WhenSecondArgumentIsGreater_ReturnsTheSecondArgument()
        {
            //Arrange
            //var math = new Fundamentals.Math();
            
            //Assert
            var result = _math.Max(5, 8);
            
            //Act
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Max_WhenBothArgsEqual_ReturnsTheSameArgument()
        {
            //Arrange
            //var math = new Fundamentals.Math();
            
            //Assert
            var result = _math.Max(3, 3);
            
            //Act
            Assert.That(result, Is.EqualTo(3));
        }
    }
}
