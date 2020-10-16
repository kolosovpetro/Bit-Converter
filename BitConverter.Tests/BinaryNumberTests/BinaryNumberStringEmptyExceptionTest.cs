using System;
using BitConverter.Exceptions;
using BitConverter.Models;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.BinaryNumberTests
{
    [TestFixture]
    public class BinaryNumberStringEmptyExceptionTest
    {
        [Test]
        public void Binary_Number_String_Empty_Exception_Test()
        {
            Action act = () => new NumberModel("", 2);
            act.Should().Throw<InvalidNumberFormatException>()
                .WithMessage("Input data cannot be empty.");
        }
    }
}