using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace SomeLibrary.Test
{
    [TestClass]
    public class FooTests
    {
        [TestMethod]
        public void Foo_GetTotal_Should_ReturnAdditionOfValues()
        {
            // Arrange
            var mockReturnValue = 10;
            var mockBar = new Mock<IBar>();
            mockBar
                .Setup(m => m.DoSomeThings())
                .Returns(() => mockReturnValue);

            var fooValue = 10;
            var foo = new Foo(fooValue, mockBar.Object);

            // Act
            var total = foo.GetTotal();

            // Assert
            total.ShouldBeEquivalentTo(fooValue + mockReturnValue);
        }
    }
}
