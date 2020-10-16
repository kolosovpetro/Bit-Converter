using System;
using BitConverter.Exceptions;
using BitConverter.Models;
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
            Action act = () => new NumberModel(null, 8);
            act.Should().Throw<NullNumberException>()
                .WithMessage("Input data cannot be null.");
        }
    }
}