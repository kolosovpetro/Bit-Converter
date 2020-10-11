using BitConverter.Validators;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.Tests
{
    [TestFixture]
    public class IsProperOctalTest
    {
        [Test]
        public void Proper_Octal_Test()
        {
            Validator.IsProperOctal("0120410213").Should().BeTrue();
            Validator.IsProperOctal("").Should().BeTrue();
            Validator.IsProperOctal(null).Should().BeTrue();
            Validator.IsProperOctal("01204102138").Should().BeFalse();
            Validator.IsProperOctal("asdasda").Should().BeFalse();
        }
    }
}