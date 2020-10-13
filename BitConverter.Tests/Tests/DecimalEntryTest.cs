using BitConverter.Models;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.Tests
{
    [TestFixture]
    public class DecimalNumberTest
    {
        [Test]
        public void Decimal_Number_Test_1()
        {
            var entry = new NumberModel("123.456", 10);
            entry.IntegerPart.Should().Be("123");
            entry.FloatPart.Should().Be("456");
        }
    }
}