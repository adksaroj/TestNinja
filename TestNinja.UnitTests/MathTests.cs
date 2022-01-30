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
        [TestCase(5,7,12)]
        public void Add_WhenCalled_ReturnsSumOfTwoArguments(int a, int b, int expectedResult)
        {
            //Arrange - done at SetUp
            //var math = new Fundamentals.Math();

            //Assert
            var result = _math.Add(a,b);
            
            //Act
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(5,7,7)]
        [TestCase(7,5,7)]
        [TestCase(3,3,3)]
        public void Max_WhenCalled_ReturnsTheGreaterArgument(int a, int b, int expectedResult)
        {
            //Arrange - done at SetUp
            //var math = new Fundamentals.Math();

            //Assert
            var result = _math.Max(a, b);
            
            //Act
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
