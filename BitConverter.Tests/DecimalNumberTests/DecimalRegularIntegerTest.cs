using BitConverter.Models;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.DecimalNumberTests
{
    [TestFixture]
    public class DecimalIntegerTest
    {
        [Test]
        public void Decimal_Integer_Test()
        {
            var number = new NumberModel("1234", 10);
            number.IntegerPart.Should().Be("1234");
            number.FloatPart.Should().Be("0");
            number.Base.Should().Be(10);
        }
    }
}