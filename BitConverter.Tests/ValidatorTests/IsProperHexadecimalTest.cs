using BitConverter.Validators;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.ValidatorTests
{
    [TestFixture]
    public class IsProperHexadecimalTest
    {
        [Test]
        public void Proper_Hexadecimal_Test()
        {
            Validator.IsProperHexadecimal("asda").Should().BeFalse();
            Validator.IsProperHexadecimal("12312").Should().BeTrue();
            Validator.IsProperHexadecimal("").Should().BeTrue();
            Validator.IsProperHexadecimal(null).Should().BeTrue();
            Validator.IsProperHexadecimal("12312BFD").Should().BeTrue();
            Validator.IsProperHexadecimal("12312BFDZ").Should().BeFalse();
        }
    }
}