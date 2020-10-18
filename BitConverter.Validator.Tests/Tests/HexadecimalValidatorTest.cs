using BitConverter.Validator.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Validator.Tests.Tests
{
    [TestFixture]
    public class HexadecimalValidatorTest
    {
        [Test]
        public void Is_Valid_Hexadecimal_Test()
        {
            IValidator validator = new Implementations.Validator();
            
            // valid inputs:
            validator.IsValidHexadecimal("123456789ABCDEF.123456789ABCDEF").Should().BeTrue();
            validator.IsValidHexadecimal("123456789ABCDEF.0").Should().BeTrue();
            
            // invalid inputs
            validator.IsValidHexadecimal("123456789ABCDEF.123456789ABCDEF.123456789ABCDEF").Should().BeFalse();
            validator.IsValidHexadecimal(".123456789ABCDEF").Should().BeFalse();
            validator.IsValidHexadecimal("123456789ABCDEF.").Should().BeFalse();
            validator.IsValidHexadecimal("123456789ABCDEF").Should().BeFalse();
            validator.IsValidHexadecimal(",123456789ABCDEF").Should().BeFalse();
            validator.IsValidHexadecimal("123456789ABCDEF,123456789ABCDEF").Should().BeFalse();
            validator.IsValidHexadecimal("123456789ABCDEF,").Should().BeFalse();
            validator.IsValidHexadecimal("123456789ABCDEF.123456789ABCDEF.123456789ABCDEF").Should().BeFalse();
            validator.IsValidHexadecimal(".123456789ABCDEF").Should().BeFalse();
            validator.IsValidHexadecimal("123456789ABCDEF.").Should().BeFalse();
            validator.IsValidHexadecimal("123456789ABCDEF").Should().BeFalse();
            validator.IsValidHexadecimal(",123456789ABCDEF").Should().BeFalse();
            validator.IsValidHexadecimal("123456789ABCDEF,123456789ABCDEF").Should().BeFalse();
            validator.IsValidHexadecimal("123456789ABCDEF,").Should().BeFalse();
        }
    }
}