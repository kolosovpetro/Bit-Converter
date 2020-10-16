using BitConverter.Models;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.BinaryNumberTests
{
    [TestFixture]
    public class BinaryFloatStartWithDotTest
    {
        [Test]
        public void Binary_Float_Starts_With_Dot_Test()
        {
            var number = new NumberModel(".001", 2);
            number.FloatPart.Should().Be("001");
            number.IntegerPart.Should().Be("0");
            number.Base.Should().Be(2);
        }
    }
}