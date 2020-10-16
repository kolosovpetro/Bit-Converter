using System;
using BitConverter.Exceptions;
using BitConverter.Models;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.DecimalNumberTests
{
    [TestFixture]
    public class DecimalNumberStringEmptyExceptionTest
    {
        [Test]
        public void Decimal_Number_String_Empty_Exception_Test()
        {
            Action act1 = () => new NumberModel("", 10);
            act1.Should().Throw<InvalidNumberFormatException>()
                .WithMessage("Input data cannot be empty.");
            
            Action act2 = () => new DecimalNumber("");
            act2.Should().Throw<InvalidNumberFormatException>()
                .WithMessage("Input data cannot be empty.");
        }
    }
}