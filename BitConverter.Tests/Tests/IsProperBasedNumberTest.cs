using System;
using BitConverter.Exceptions;
using BitConverter.Validators;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.Tests
{
    [TestFixture]
    public class IsProperBasedNumberTest
    {
        [Test]
        public void Is_Proper_Bases_Number_Test()
        {
            Validator.IsProperNumber("01010101", 2).Should().BeTrue();
            Validator.IsProperNumber("", 2).Should().BeTrue();
            Validator.IsProperNumber(null, 2).Should().BeTrue();
            Validator.IsProperNumber("010101012", 2).Should().BeFalse();
            Validator.IsProperNumber("1231657", 8).Should().BeTrue();
            Validator.IsProperNumber("", 8).Should().BeTrue();
            Validator.IsProperNumber(null, 8).Should().BeTrue();
            Validator.IsProperNumber("12316578", 8).Should().BeFalse();
            Validator.IsProperNumber("1231657", 10).Should().BeTrue();
            Validator.IsProperNumber("", 10).Should().BeTrue();
            Validator.IsProperNumber(null, 10).Should().BeTrue();
            Validator.IsProperNumber("1231657F", 10).Should().BeFalse();
            Validator.IsProperNumber("1231657F", 16).Should().BeTrue();
            Validator.IsProperNumber("", 16).Should().BeTrue();
            Validator.IsProperNumber(null, 16).Should().BeTrue();

            Action act = () => Validator.IsProperNumber("12312", 11);

            act.Should().Throw<UnsupportedBaseException>()
                .WithMessage("Provided base is not supported.");
        }
    }
}