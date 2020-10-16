using BitConverter.Models;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.DecimalNumberTests
{
    [TestFixture]
    public class DecimalFloatDotSeparatedTest
    {
        [Test]
        public void Decimal_Float_Dot_Separated_Test()
        {
            var number = new NumberModel("123.456", 10);
            number.IntegerPart.Should().Be("123");
            number.FloatPart.Should().Be("456");
            number.Base.Should().Be(10);
        }
    }
}