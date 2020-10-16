using BitConverter.Models;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.OctalNumberTests
{
    [TestFixture]
    public class OctalIntegerEndsWithCommaTest
    {
        [Test]
        public void Octal_Integer_Ends_With_Comma_Test()
        {
            var number = new NumberModel("123,", 8);
            number.FloatPart.Should().Be("0");
            number.IntegerPart.Should().Be("123");
            number.Base.Should().Be(8);
        }
    }
}