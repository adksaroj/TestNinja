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
    public class HtmlFormatterTests
    {
        private HtmlFormatter _htmlFormatter;

        [SetUp]
        public void Setup()
        {
            //Arrange
            _htmlFormatter = new HtmlFormatter();
        }

        [Test]
        [TestCase("hello")]
        public void FormatAsBold_WhenCalled_ReturnsBoldString(string inputString)
        {
            //Act
            var result = _htmlFormatter.FormatAsBold(inputString);

            //Assert - Specific
            Assert.That(result, Is.EqualTo($"<strong>{inputString}</strong>"));

            //More general
            //Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            //Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
            //Assert.That(result, Does.Contain(inputString));
        }
    }
}
