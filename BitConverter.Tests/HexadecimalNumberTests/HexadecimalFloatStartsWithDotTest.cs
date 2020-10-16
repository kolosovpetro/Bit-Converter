using BitConverter.Models;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.HexadecimalNumberTests
{
    [TestFixture]
    public class HexadecimalFloatStartsWithDotTest
    {
        [Test]
        public void Hexadecimal_Float_Starts_With_Dot_Test()
        {
            var number = new NumberModel(".1D", 16);
            number.IntegerPart.Should().Be("0");
            number.FloatPart.Should().Be("1D");
            number.Base.Should().Be(16);
        }
    }
}