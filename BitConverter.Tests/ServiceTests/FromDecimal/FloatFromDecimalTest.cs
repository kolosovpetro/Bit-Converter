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
            FloatPartFromDecimal.Convert(new DecimalNumber("0.372"), 2).Should().Be("010111");
            FloatPartFromDecimal.Convert(new DecimalNumber("15.231"), 8).Should().Be("166213");
            FloatPartFromDecimal.Convert(new DecimalNumber("15.231"), 16).Should().Be("3B22D0");
            FloatPartFromDecimal.Convert(new DecimalNumber("15.231"), 2).Should().Be("001110");
            FloatPartFromDecimal.Convert(new DecimalNumber("521.5"), 8).Should().Be("400000");
            FloatPartFromDecimal.Convert(new DecimalNumber("521.5"), 16).Should().Be("800000");
            FloatPartFromDecimal.Convert(new DecimalNumber("521.5"), 2).Should().Be("100000");
            FloatPartFromDecimal.Convert(new DecimalNumber("83.05"), 8).Should().Be("031463");
            FloatPartFromDecimal.Convert(new DecimalNumber("83.05"), 16).Should().Be("0CCCCC");
            FloatPartFromDecimal.Convert(new DecimalNumber("83.05"), 2).Should().Be("000011");
        }
    }
}