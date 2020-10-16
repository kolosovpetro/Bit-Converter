using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.OctalNumberTests
{
    [TestFixture]
    public class OctalFloatDotSeparatedTest
    {
        [Test]
        public void Octal_Float_Dot_Separated_Test()
        {
            INumber number = new NumberModel("123.456", 8);
            number.IntegerPart.Should().Be("123");
            number.FloatPart.Should().Be("456");
            number.Base.Should().Be(8);
            
            number = new OctalNumber("123.456");
            number.IntegerPart.Should().Be("123");
            number.FloatPart.Should().Be("456");
            number.Base.Should().Be(8);
        }
    }
}