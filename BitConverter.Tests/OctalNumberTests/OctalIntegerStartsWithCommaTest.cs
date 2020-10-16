using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.OctalNumberTests
{
    [TestFixture]
    public class OctalIntegerStartsWithCommaTest
    {
        [Test]
        public void Octal_Integer_Starts_With_Comma_Test()
        {
            INumber number = new NumberModel(",123", 8);
            number.FloatPart.Should().Be("123");
            number.IntegerPart.Should().Be("0");
            number.Base.Should().Be(8);
            
            number = new OctalNumber(",123");
            number.FloatPart.Should().Be("123");
            number.IntegerPart.Should().Be("0");
            number.Base.Should().Be(8);
        }
    }
}