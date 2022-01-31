using NUnit.Framework;
using TestNinja.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.UnitTests
{
    [TestFixture()]
    public class FizzBuzzTests
    {
        //private FizzBuzz _fizzBuzz;

        //[SetUp]
        //public void SetUpTests()
        //{
        //    _fizzBuzz = new FizzBuzz();
        //}

        [Test()]
        [TestCase(7)]
        public void GetOutput_WhenNoNotDivisbleByThreeAndFive_ReturnsSameNumber(int num)
        {
            var result = FizzBuzz.GetOutput(num);
            Assert.That(result, Is.EqualTo(num.ToString()));
        }

        [Test()]
        [TestCase(3)]
        [TestCase(9)]
        public void GetOutput_WhenNoIsDivisbleByThree_ReturnsFizz(int num)
        {
            var result = FizzBuzz.GetOutput(num);
            Assert.That(result, Is.EqualTo("Fizz").IgnoreCase);
        }

        [Test()]
        [TestCase(5)]
        [TestCase(20)]
        public void GetOutput_WhenNoIsDivisbleByFive_ReturnsBuzz(int num)
        {
            var result = FizzBuzz.GetOutput(num);
            Assert.That(result, Is.EqualTo("Buzz").IgnoreCase);
        }

        [Test()]
        [TestCase(15)]
        [TestCase(30)]
        public void GetOutput_WhenNoIsDivisbleByThreeAndFive_ReturnsFizzBuzz(int num)
        {
            var result = FizzBuzz.GetOutput(num);
            Assert.That(result, Is.EqualTo("FizzBuzz").IgnoreCase);
        }
    }
}