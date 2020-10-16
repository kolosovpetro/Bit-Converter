using System;
using BitConverter.Exceptions;
using BitConverter.Models;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.OctalNumberTests
{
    [TestFixture]
    public class OctalNumberNullExceptionTest
    {
        [Test]
        public void Octal_Number_Exception_Test()
        {
            Action act1 = () => new NumberModel(null, 8);
            act1.Should().Throw<NullNumberException>()
                .WithMessage("Input data cannot be null.");
            
            Action act2 = () => new OctalNumber(null);
            act2.Should().Throw<NullNumberException>()
                .WithMessage("Input data cannot be null.");
        }
    }
}