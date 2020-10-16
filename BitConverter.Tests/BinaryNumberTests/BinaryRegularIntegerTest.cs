using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Numbers;
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
            INumber number = new NumberModel("1010101", 2);
            number.FloatPart.Should().Be("0");
            number.IntegerPart.Should().Be("1010101");
            number.Base.Should().Be(2);
            
            number = new BinaryNumber("1010101");
            number.FloatPart.Should().Be("0");
            number.IntegerPart.Should().Be("1010101");
            number.Base.Should().Be(2);
        }
    }
}