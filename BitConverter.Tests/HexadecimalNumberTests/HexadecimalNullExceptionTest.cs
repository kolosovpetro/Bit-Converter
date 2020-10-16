using System;
using BitConverter.Exceptions;
using BitConverter.Models;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.HexadecimalNumberTests
{
    [TestFixture]
    public class HexadecimalNullExceptionTest
    {
        [Test]
        public void Hexadecimal_Null_Exception_Test()
        {
            Action act1 = () => new NumberModel(null, 16);
            act1.Should().Throw<NullNumberException>()
                .WithMessage("Input data cannot be null.");
            
            Action act2 = () => new HexadecimalNumber(null);
            act2.Should().Throw<NullNumberException>()
                .WithMessage("Input data cannot be null.");
        }
    }
}