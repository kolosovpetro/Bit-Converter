using BitConverter.Validator.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Validator.Tests.Tests
{
    [TestFixture]
    public class DecimalValidatorTest
    {
        [Test]
        public void Decimal_Validator_Test()
        {
            IValidator validator = new Implementations.Validator();
            
            // valid inputs:
            validator.IsValidDecimal("123456789.123456789").Should().BeTrue();
            validator.IsValidDecimal("123456789.0").Should().BeTrue();
            
            // invalid inputs
            validator.IsValidDecimal("123456789.123456789.123456789").Should().BeFalse();
            validator.IsValidDecimal(".123456789").Should().BeFalse();
            validator.IsValidDecimal("123456789.").Should().BeFalse();
            validator.IsValidDecimal("123456789").Should().BeFalse();
            validator.IsValidDecimal(",123456789").Should().BeFalse();
            validator.IsValidDecimal("123456789,123456789").Should().BeFalse();
            validator.IsValidDecimal("123456789,").Should().BeFalse();
            validator.IsValidDecimal("123456789.123456789.123456789").Should().BeFalse();
            validator.IsValidDecimal(".123456789").Should().BeFalse();
            validator.IsValidDecimal("123456789.").Should().BeFalse();
            validator.IsValidDecimal("123456789").Should().BeFalse();
            validator.IsValidDecimal(",123456789").Should().BeFalse();
            validator.IsValidDecimal("123456789,123456789").Should().BeFalse();
            validator.IsValidDecimal("123456789,").Should().BeFalse();
        }
    }
}