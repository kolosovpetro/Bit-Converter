using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.HexadecimalNumberTests
{
    [TestFixture]
    public class HexadecimalIntegerEndsWithCommaTest
    {
        [Test]
        public void Hexadecimal_Integer_Ends_With_Comma_Test()
        {
            INumber number = new NumberModel("1DF2,", 16);
            number.IntegerPart.Should().Be("1DF2");
            number.FloatPart.Should().Be("0");
            number.Base.Should().Be(16);
            
            number = new HexadecimalNumber("1DF2,");
            number.IntegerPart.Should().Be("1DF2");
            number.FloatPart.Should().Be("0");
            number.Base.Should().Be(16);
        }
    }
}