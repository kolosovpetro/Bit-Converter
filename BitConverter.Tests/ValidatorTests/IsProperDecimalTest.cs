using BitConverter.Validators;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.ValidatorTests
{
    [TestFixture]
    public class IsProperDecimalTest
    {
        [Test]
        public void Proper_Decimal_Test()
        {
            Validator.IsProperDecimal("1231231").Should().BeTrue();
            Validator.IsProperDecimal("").Should().BeTrue();
            Validator.IsProperDecimal(null).Should().BeTrue();
            Validator.IsProperDecimal("00001").Should().BeTrue();
            Validator.IsProperDecimal("00001F").Should().BeFalse();
        }
    }
}