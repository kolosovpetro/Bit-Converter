using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.OctalNumberTests
{
    [TestFixture]
    public class OctalNumberToStringTest
    {
        [Test]
        public void Octal_Number_To_String_Test()
        {
            new OctalNumber(".12345").ToString().Should().Be("00.12345");
            new OctalNumber("0.12345").ToString().Should().Be("00.12345");
            new OctalNumber(",12345").ToString().Should().Be("00.12345");
            new OctalNumber("0,12345").ToString().Should().Be("00.12345");
            new OctalNumber("12345.").ToString().Should().Be("012345.0");
            new OctalNumber("12345.0").ToString().Should().Be("012345.0");
            new OctalNumber("12345,").ToString().Should().Be("012345.0");
            new OctalNumber("12345,0").ToString().Should().Be("012345.0");
            new OctalNumber("12345").ToString().Should().Be("012345.0");
        }
    }
}