using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.BinaryNumberTests
{
    [TestFixture]
    public class BinaryNumberToStringTest
    {
        [Test]
        public void Binary_Number_To_String_Test()
        {
            new BinaryNumber(".010").ToString().Should().Be("0.010");
            new BinaryNumber("0.010").ToString().Should().Be("0.010");
            new BinaryNumber(",010").ToString().Should().Be("0.010");
            new BinaryNumber("0,010").ToString().Should().Be("0.010");
            new BinaryNumber("101,").ToString().Should().Be("101.0");
            new BinaryNumber("101.").ToString().Should().Be("101.0");
            new BinaryNumber("101").ToString().Should().Be("101.0");
        }
    }
}