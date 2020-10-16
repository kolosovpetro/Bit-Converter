using System;
using BitConverter.Exceptions;
using BitConverter.Models;
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
            Action act = () => new NumberModel(null, 16);
            act.Should().Throw<NullNumberException>()
                .WithMessage("Input data cannot be null.");
        }
    }
}