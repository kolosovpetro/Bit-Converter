using System;
using BitConverter.Exceptions;
using BitConverter.Models;
using BitConverter.Numbers;
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
            Action act1 = () => new NumberModel("", 16);
            act1.Should().Throw<InvalidNumberFormatException>()
                .WithMessage("Input data cannot be empty.");
            
            Action act2 = () => new HexadecimalNumber("");
            act2.Should().Throw<InvalidNumberFormatException>()
                .WithMessage("Input data cannot be empty.");
        }
    }
}