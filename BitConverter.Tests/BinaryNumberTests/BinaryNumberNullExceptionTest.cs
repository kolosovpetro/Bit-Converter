using System;
using BitConverter.Exceptions;
using BitConverter.Models;
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
            Action act = () => new NumberModel(null, 2);
            act.Should().Throw<NullNumberException>()
                .WithMessage("Input data cannot be null.");
        }
    }
}