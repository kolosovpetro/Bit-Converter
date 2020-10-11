using BitConverter.Validators;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.Tests
{
    [TestFixture]
    public class RegexTest
    {
        [Test]
        public void Regex_Test()
        {
            Validator.IsValid("123").Should().BeTrue();
            Validator.IsValid("123.456").Should().BeTrue();
            Validator.IsValid(".456").Should().BeTrue();
            Validator.IsValid("asda.asd").Should().BeFalse();
            Validator.IsValid("123,2").Should().BeTrue();
            Validator.IsValid(",023").Should().BeTrue();
            Validator.IsValid("0001").Should().BeTrue();
            Validator.IsValidHexadecimal("AF.DF").Should().BeTrue();
            Validator.IsValidHexadecimal("AF.").Should().BeTrue();
            Validator.IsValidHexadecimal("10.FD").Should().BeTrue();
            Validator.IsValidHexadecimal("0010.FD").Should().BeTrue();
            Validator.IsValidHexadecimal(".FD").Should().BeTrue();
            Validator.IsValidHexadecimal("AB.").Should().BeTrue();
        }
    }
}