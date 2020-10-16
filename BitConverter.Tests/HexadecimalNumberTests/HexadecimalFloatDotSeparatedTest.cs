using BitConverter.Models;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.HexadecimalNumberTests
{
    [TestFixture]
    public class HexadecimalFloatDotSeparatedTest
    {
        [Test]
        public void Hexadecimal_Float_Dot_Separated_Test()
        {
            var number = new NumberModel("AD.FD", 16);
            number.IntegerPart.Should().Be("AD");
            number.FloatPart.Should().Be("FD");
            number.Base.Should().Be(16);
        }
    }
}