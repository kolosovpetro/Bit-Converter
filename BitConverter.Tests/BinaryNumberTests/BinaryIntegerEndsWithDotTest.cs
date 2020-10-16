using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Numbers;
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
            INumber number = new NumberModel("01010.", 2);
            number.FloatPart.Should().Be("0");
            number.IntegerPart.Should().Be("01010");
            number.Base.Should().Be(2);
            
            number = new BinaryNumber("01010.");
            number.FloatPart.Should().Be("0");
            number.IntegerPart.Should().Be("01010");
            number.Base.Should().Be(2);
        }
    }
}