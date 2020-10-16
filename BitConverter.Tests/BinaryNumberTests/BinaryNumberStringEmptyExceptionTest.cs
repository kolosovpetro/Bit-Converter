using System;
using BitConverter.Exceptions;
using BitConverter.Models;
using BitConverter.Numbers;
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
            Action act1 = () => new NumberModel("", 2);
            act1.Should().Throw<InvalidNumberFormatException>()
                .WithMessage("Input data cannot be empty.");
            
            Action act2 = () => new BinaryNumber("");
            act2.Should().Throw<InvalidNumberFormatException>()
                .WithMessage("Input data cannot be empty.");
        }
    }
}