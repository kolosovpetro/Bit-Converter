using BitConverter.Models;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.DecimalNumberTests
{
    [TestFixture]
    public class DecimalIntegerEndsWithDotTest
    {
        [Test]
        public void Decimal_Integer_Ends_With_Dot_Test()
        {
            var number = new NumberModel("123.", 10);
            number.FloatPart.Should().Be("0");
            number.IntegerPart.Should().Be("123");
            number.Base.Should().Be(10);
        }
    }
}