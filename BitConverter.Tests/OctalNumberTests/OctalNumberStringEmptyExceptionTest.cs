using System;
using BitConverter.Exceptions;
using BitConverter.Models;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.OctalNumberTests
{
    [TestFixture]
    public class OctalNumberStringEmptyExceptionTest
    {
        [Test]
        public void Octal_Number_String_Empty_Exception_Test()
        {
            Action act1 = () => new NumberModel("", 8);
            act1.Should().Throw<InvalidNumberFormatException>()
                .WithMessage("Input data cannot be empty.");
            
            Action act2 = () => new OctalNumber("");
            act2.Should().Throw<InvalidNumberFormatException>()
                .WithMessage("Input data cannot be empty.");
        }
    }
}