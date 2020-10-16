using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Numbers;
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
            INumber number = new NumberModel(".001", 2);
            number.FloatPart.Should().Be("001");
            number.IntegerPart.Should().Be("0");
            number.Base.Should().Be(2);

            number = new BinaryNumber(".001");
            number.FloatPart.Should().Be("001");
            number.IntegerPart.Should().Be("0");
            number.Base.Should().Be(2);
        }
    }
}