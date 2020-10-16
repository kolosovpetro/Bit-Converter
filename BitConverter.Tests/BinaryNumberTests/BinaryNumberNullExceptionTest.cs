using System;
using BitConverter.Exceptions;
using BitConverter.Models;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.BinaryNumberTests
{
    [TestFixture]
    public class BinaryNumberNullExceptionTest
    {
        [Test]
        public void Binary_Number_Null_Exception_Test()
        {
            Action act1 = () => new NumberModel(null, 2);
            act1.Should().Throw<NullNumberException>()
                .WithMessage("Input data cannot be null.");
            
            Action act2 = () => new BinaryNumber(null);
            act2.Should().Throw<NullNumberException>()
                .WithMessage("Input data cannot be null.");
        }
    }
}