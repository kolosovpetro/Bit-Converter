using BitConverter.Numbers;
using BitConverter.Services.FromDecimal;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.ServiceTests.FromDecimal
{
    [TestFixture]
    public class IntegerFromDecimalTest
    {
        [Test]
        public void Convert_Integer_From_Decimal_Test()
        {
            IntegerPartFromDecimal.Convert(new DecimalNumber("1000.0"), 2).Should().Be("1111101000");
            IntegerPartFromDecimal.Convert(new DecimalNumber("243.0"), 8).Should().Be("363");
            IntegerPartFromDecimal.Convert(new DecimalNumber("1000.0"), 16).Should().Be("3E8");
            IntegerPartFromDecimal.Convert(new DecimalNumber("123131.0"), 16).Should().Be("1E0FB");
            IntegerPartFromDecimal.Convert(new DecimalNumber("123131.0"), 10).Should().Be("123131");
        }
    }
}