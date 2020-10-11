using BitConverter.Validators;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.Tests
{
    [TestFixture]
    public class IsProperBinaryTest
    {
        [Test]
        public void Proper_Binary_Test()
        {
            Validator.IsProperBinary("01010101").Should().BeTrue();
            Validator.IsProperBinary("").Should().BeTrue();
            Validator.IsProperBinary(null).Should().BeTrue();
            Validator.IsProperBinary("012315").Should().BeFalse();
            Validator.IsProperBinary("012315.1").Should().BeFalse();
            Validator.IsProperBinary("asda.sas").Should().BeFalse();
        }
    }
}