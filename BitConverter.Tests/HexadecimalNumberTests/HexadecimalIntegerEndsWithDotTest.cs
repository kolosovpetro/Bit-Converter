using BitConverter.Models;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.HexadecimalNumberTests
{
    [TestFixture]
    public class HexadecimalIntegerEndsWithDotTest
    {
        [Test]
        public void Hexadecimal_Integer_Ends_With_Dot_Test()
        {
            var number = new NumberModel("1DF2.", 16);
            number.IntegerPart.Should().Be("1DF2");
            number.FloatPart.Should().Be("0");
            number.Base.Should().Be(16);
        }
    }
}