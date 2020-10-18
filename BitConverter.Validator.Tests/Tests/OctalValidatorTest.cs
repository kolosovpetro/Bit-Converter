using BitConverter.Validator.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Validator.Tests.Tests
{
    [TestFixture]
    public class OctalValidatorTest
    {
        [Test]
        public void Octal_Validator_Test()
        {
            IValidator validator = new Implementations.Validator();
            
            // valid inputs:
            validator.IsValidOctal("1234567.1234567").Should().BeTrue();
            validator.IsValidOctal("1234567.0").Should().BeTrue();
            
            // invalid inputs
            validator.IsValidOctal("1234567.1234567.1234567").Should().BeFalse();
            validator.IsValidOctal(".1234567").Should().BeFalse();
            validator.IsValidOctal("1234567.").Should().BeFalse();
            validator.IsValidOctal("1234567").Should().BeFalse();
            validator.IsValidOctal(",1234567").Should().BeFalse();
            validator.IsValidOctal("1234567,1234567").Should().BeFalse();
            validator.IsValidOctal("1234567,").Should().BeFalse();
            validator.IsValidOctal("1234567.1234567.1234567").Should().BeFalse();
            validator.IsValidOctal(".1234567").Should().BeFalse();
            validator.IsValidOctal("1234567.").Should().BeFalse();
            validator.IsValidOctal("1234567").Should().BeFalse();
            validator.IsValidOctal(",1234567").Should().BeFalse();
            validator.IsValidOctal("1234567,1234567").Should().BeFalse();
            validator.IsValidOctal("1234567,").Should().BeFalse();
        }
    }
}