using System;
using BitConverter.Exceptions;
using BitConverter.Models;
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
            Action act = () => new NumberModel("", 10);
            act.Should().Throw<InvalidNumberFormatException>()
                .WithMessage("Input data cannot be empty.");
        }
    }
}