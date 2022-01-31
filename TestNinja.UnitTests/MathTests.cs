using NUnit.Framework;
using System.Linq;

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
        //[Ignore("I wanted to")]
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

        [Test]
        [TestCase(5)]
        //[TestCase(-2)]
        //[TestCase(6)]
        //[TestCase(17)]
        public void GetOddNumbers_WhenCalled_ReturnsCollectionOfOddNosLessThanEqualsLimit(int limit)
        {
            //Act
            var results = _math.GetOddNumbers(limit);

            //Assert
            //Assert.That(results, Is.Not.Empty);
            //Assert.That(results.Count(),Is.EqualTo(5));
            //Assert.That(results, Is.Ordered);
            //Assert.That(results, Is.Unique);

            Assert.That(results, Is.EquivalentTo(new[] { 1,3,5}));
        }
    }
}
