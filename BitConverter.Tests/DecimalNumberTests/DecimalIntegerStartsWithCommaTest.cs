using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.DecimalNumberTests
{
    [TestFixture]
    public class DecimalIntegerStartsWithCommaTest
    {
        [Test]
        public void Decimal_Integer_Starts_With_Comma_Test()
        {
            INumber number = new NumberModel(",123", 10);
            number.FloatPart.Should().Be("123");
            number.IntegerPart.Should().Be("0");
            number.Base.Should().Be(10);
            
            number = new DecimalNumber(",123");
            number.FloatPart.Should().Be("123");
            number.IntegerPart.Should().Be("0");
            number.Base.Should().Be(10);
        }
    }
}