using BitConverter.Models;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.BinaryNumberTests
{
    [TestFixture]
    public class BinaryIntegerEndsWithDotTest
    {
        [Test]
        public void Binary_Integer_Ends_With_Dot_Test()
        {
            var number = new NumberModel("01010.", 2);
            number.FloatPart.Should().Be("0");
            number.IntegerPart.Should().Be("01010");
            number.Base.Should().Be(2);
        }
    }
}