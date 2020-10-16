using BitConverter.Models;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.BinaryNumberTests
{
    [TestFixture]
    public class BinaryRegularFloatTest
    {
        [Test]
        public void Binary_Regular_Float_Comma_Separated_Test()
        {
            var number = new NumberModel("100101,010101", 2);
            number.IntegerPart.Should().Be("100101");
            number.FloatPart.Should().Be("010101");
            number.Base.Should().Be(2);
        }
        
        [Test]
        public void Binary_Regular_Float_Dot_Separated_Test()
        {
            var number = new NumberModel("100101.010101", 2);
            number.IntegerPart.Should().Be("100101");
            number.FloatPart.Should().Be("010101");
            number.Base.Should().Be(2);
        }
    }
}