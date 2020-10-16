using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.DecimalNumberTests
{
    [TestFixture]
    public class DecimalIntegerEndsWithCommaTest
    {
        [Test]
        public void Decimal_Integer_Ends_With_Comma_Test()
        {
            INumber number = new NumberModel("123,", 10);
            number.FloatPart.Should().Be("0");
            number.IntegerPart.Should().Be("123");
            number.Base.Should().Be(10);
            
            number = new DecimalNumber("123,");
            number.FloatPart.Should().Be("0");
            number.IntegerPart.Should().Be("123");
            number.Base.Should().Be(10);
        }
    }
}