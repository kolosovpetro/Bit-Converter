using System;
using BitConverter.Exceptions;
using BitConverter.Models;
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
            Action act = () => new NumberModel(null, 10);
            act.Should().Throw<NullNumberException>()
                .WithMessage("Input data cannot be null.");
        }
    }
}