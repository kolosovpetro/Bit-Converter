using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.HexadecimalNumberTests
{
    [TestFixture]
    public class HexadecimalFloatStartsWithCommaTest
    {
        [Test]
        public void Hexadecimal_Float_Starts_With_Comma_Test()
        {
            INumber number = new NumberModel(",1D", 16);
            number.IntegerPart.Should().Be("0");
            number.FloatPart.Should().Be("1D");
            number.Base.Should().Be(16);
            
            number = new HexadecimalNumber(",1D");
            number.IntegerPart.Should().Be("0");
            number.FloatPart.Should().Be("1D");
            number.Base.Should().Be(16);
        }
    }
}