using BitConverter.Models;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.OctalNumberTests
{
    [TestFixture]
    public class OctalFloatCommaSeparated
    {
        [Test]
        public void Octal_Float_Comma_Separated_Test()
        {
            var number = new NumberModel("123,456", 8);
            number.IntegerPart.Should().Be("123");
            number.FloatPart.Should().Be("456");
            number.Base.Should().Be(8);
        }
    }
}