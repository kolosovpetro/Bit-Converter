using BitConverter.Validators;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.ValidatorTests
{
    [TestFixture]
    public class IsValidHexadecimalTest
    {
        [Test]
        public void Is_Valid_Hexadecimal_Test()
        {
            Validator.IsValidHexadecimal("AF").Should().BeTrue();
            Validator.IsValidHexadecimal("AF.").Should().BeTrue();
            Validator.IsValidHexadecimal("AF.2FD").Should().BeTrue();
            Validator.IsValidHexadecimal(".AF").Should().BeTrue();
            Validator.IsValidHexadecimal("2FD.AF").Should().BeTrue();
            Validator.IsValidHexadecimal("2FD.AFX").Should().BeFalse();
            Validator.IsValidHexadecimal("2FDX").Should().BeFalse();
            Validator.IsValidHexadecimal(".2FDX").Should().BeFalse();
            Validator.IsValidHexadecimal("2FDX.").Should().BeFalse();
        }
    }
}