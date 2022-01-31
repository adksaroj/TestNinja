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
    class ErrorLoggerTests
    {
        public ErrorLogger _errorLogger { get; private set; }

        [SetUp]
        public void SetupTests()
        {
            _errorLogger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenErrorMessageNotEmpty_ShouldSetLassErrorProperty()
        {
            _errorLogger.Log("test"); //return type is void

            //Assert
            Assert.That(_errorLogger.LastError, Is.EqualTo("test"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_WhenErrorMessageEmpty_ShouldThrowArugmentNullException(string error)
        {
            //_errorLogger.Log(error); // throws

            //Assert
            Assert.That(()=> _errorLogger.Log(error),Throws.ArgumentNullException);
            //Assert.That(()=> _errorLogger.Log(error),Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        [TestCase("error")]
        public void Log_ValidError_ShouldRaiseErrorLoggedEvent(string error)
        {
            var id = Guid.Empty;
            _errorLogger.ErrorLogged += (sender, args) => { id = args; }; //Subscribe to event

            _errorLogger.Log(error);

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
