using BitConverter.Validator.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Validator.Tests.Tests
{
    [TestFixture]
    public class BinaryValidatorTest
    {
        [Test]
        public void Binary_Validator_Test()
        {
            IValidator validator = new Implementations.Validator();
            validator.IsValidBinary(".").Should().BeFalse();
            validator.IsValidBinary("12.12").Should().BeFalse();
            validator.IsValidBinary(".101").Should().BeTrue();
            validator.IsValidBinary("111.101").Should().BeTrue();
            validator.IsValidBinary("111.").Should().BeTrue();
            validator.IsValidBinary("111,").Should().BeFalse();
            validator.IsValidBinary("111,111").Should().BeFalse();
            validator.IsValidBinary("111,").Should().BeFalse();
        }
    }
}