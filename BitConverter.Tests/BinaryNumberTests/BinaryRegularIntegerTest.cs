using BitConverter.Models;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.BinaryNumberTests
{
    [TestFixture]
    public class BinaryRegularIntegerTest
    {
        [Test]
        public void Binary_Regular_Integer_Test()
        {
            var number = new NumberModel("1010101", 2);
            number.FloatPart.Should().Be("0");
            number.IntegerPart.Should().Be("1010101");
            number.Base.Should().Be(2);
        }
    }
}