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
    public class StackTests
    {
        private Fundamentals.Stack<object> _stack;

        [SetUp]
        public void SetupTests()
        {
            _stack = new Fundamentals.Stack<object>();
        }

        [Test]
        public void Push_WhenObjIsNull_ThrowsArgumentNullException()
        {
            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_WhenObjIsNotNull_CountShouldBeOne()
        {
            _stack.Push(new object());
            Assert.That(_stack.Count, Is.EqualTo(1));

        }

        [Test]
        public void Pop_WhenCountIsZero_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Pop_WhenCountIsNonZero_ReturnsObjectAndDecrementsCount()
        {
            _stack.Push(new object());
            var result = _stack.Pop();
            Assert.That(result, Is.TypeOf<object>());
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Peek_WhenCountIsZero_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Peek(), Throws.Exception.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Peek_WhenCountIsNonZero_ReturnsObject()
        {
            _stack.Push(new object());
            var result = _stack.Peek();
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<object>());
        }
    }
}