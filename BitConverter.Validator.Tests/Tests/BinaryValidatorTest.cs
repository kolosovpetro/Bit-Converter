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
            
            // valid inputs:
            validator.IsValidBinary("111.111").Should().BeTrue();
            validator.IsValidBinary("111.0").Should().BeTrue();
            
            // invalid inputs
            validator.IsValidBinary("111.111.111").Should().BeFalse();
            validator.IsValidBinary(".111").Should().BeFalse();
            validator.IsValidBinary("111.").Should().BeFalse();
            validator.IsValidBinary("111").Should().BeFalse();
            validator.IsValidBinary(",111").Should().BeFalse();
            validator.IsValidBinary("111,111").Should().BeFalse();
            validator.IsValidBinary("111,").Should().BeFalse();
            validator.IsValidBinary("112.112.112").Should().BeFalse();
            validator.IsValidBinary(".112").Should().BeFalse();
            validator.IsValidBinary("112.").Should().BeFalse();
            validator.IsValidBinary("112").Should().BeFalse();
            validator.IsValidBinary(",112").Should().BeFalse();
            validator.IsValidBinary("121,121").Should().BeFalse();
            validator.IsValidBinary("211,").Should().BeFalse();
        }
    }
}