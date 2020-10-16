using System;
using BitConverter.Exceptions;
using BitConverter.Models;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.HexadecimalNumberTests
{
    [TestFixture]
    public class HexadecimalEmptyExceptionTest
    {
        [Test]
        public void Hexadecimal_Empty_Exception_Test()
        {
            Action act = () => new NumberModel("", 16);
            act.Should().Throw<InvalidNumberFormatException>()
                .WithMessage("Input data cannot be empty.");
        }
    }
}