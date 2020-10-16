using System;
using BitConverter.Exceptions;
using BitConverter.Models;
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
            Action act = () => new NumberModel("", 8);
            act.Should().Throw<InvalidNumberFormatException>()
                .WithMessage("Input data cannot be empty.");
        }
    }
}