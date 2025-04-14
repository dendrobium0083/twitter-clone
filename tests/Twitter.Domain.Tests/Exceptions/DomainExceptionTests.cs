using System;
using Twitter.Domain.Exceptions;
using Xunit;
using FluentAssertions;

namespace Twitter.Domain.Tests.Exceptions
{
    public class DomainExceptionTests
    {
        [Fact]
        public void Constructor_WithMessage_ShouldSetMessage()
        {
            // Arrange
            var message = "ドメインルールに違反しました";

            // Act
            var exception = new DomainException(message);

            // Assert
            exception.Message.Should().Be(message);
        }

        [Fact]
        public void Constructor_WithMessageAndInnerException_ShouldSetProperties()
        {
            // Arrange
            var message = "内部エラーが発生しました";
            var inner = new InvalidOperationException("内部例外");

            // Act
            var exception = new DomainException(message, inner);

            // Assert
            exception.Message.Should().Be(message);
            exception.InnerException.Should().Be(inner);
        }

        [Fact]
        public void DomainException_ShouldBeOfTypeException()
        {
            // Act
            var ex = new DomainException("test");

            // Assert
            ex.Should().BeAssignableTo<Exception>();
        }
    }
}
