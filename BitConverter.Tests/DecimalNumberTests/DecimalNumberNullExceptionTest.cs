using System;
using BitConverter.Exceptions;
using BitConverter.Models;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.DecimalNumberTests
{
    [TestFixture]
    public class DecimalNumberNullExceptionTest
    {
        [Test]
        public void Decimal_Number_Exception_Test()
        {
            Action act1 = () => new NumberModel(null, 10);
            act1.Should().Throw<NullNumberException>()
                .WithMessage("Input data cannot be null.");
            
            Action act2 = () => new DecimalNumber(null);
            act2.Should().Throw<NullNumberException>()
                .WithMessage("Input data cannot be null.");
        }
    }
}