using BitConverter.Numbers;
using BitConverter.Services.FromDecimal;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.ServiceTests.FromDecimal
{
    [TestFixture]
    public class FloatFromDecimalTest
    {
        [Test]
        public void Float_From_Decimal_Convert_Test()
        {
            FloatFromDecimal.Convert(new DecimalNumber("0.372"), 2).Should().Be("010111");
            FloatFromDecimal.Convert(new DecimalNumber("15.231"), 8).Should().Be("166213");
            FloatFromDecimal.Convert(new DecimalNumber("15.231"), 16).Should().Be("3B22D0");
            FloatFromDecimal.Convert(new DecimalNumber("15.231"), 2).Should().Be("001110");
        }
    }
}