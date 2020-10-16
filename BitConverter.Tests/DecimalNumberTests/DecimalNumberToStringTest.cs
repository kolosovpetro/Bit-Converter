using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.DecimalNumberTests
{
    [TestFixture]
    public class DecimalNumberToStringTest
    {
        [Test]
        public void Decimal_Number_To_String_Test()
        {
            new DecimalNumber("1235.").ToString().Should().Be("1235.0");
            new DecimalNumber("1235.0").ToString().Should().Be("1235.0");
            new DecimalNumber("1235,").ToString().Should().Be("1235.0");
            new DecimalNumber("1235,0").ToString().Should().Be("1235.0");
            new DecimalNumber(".1235").ToString().Should().Be("0.1235");
            new DecimalNumber("0.1235").ToString().Should().Be("0.1235");
            new DecimalNumber(",1235").ToString().Should().Be("0.1235");
            new DecimalNumber("0,1235").ToString().Should().Be("0.1235");
        }
    }
}