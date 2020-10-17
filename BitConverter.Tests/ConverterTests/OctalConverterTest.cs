using BitConverter.Converters;
using BitConverter.Interfaces;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.ConverterTests
{
    [TestFixture]
    public class OctalConverterTest
    {
        [Test]
        public void Octal_Converter_Test()
        {
            IConverter converter = new OctalConverter(new DecimalNumber("1234.5678"));
            var converted = converter.Convert();
            converted.IntegerPart.Should().Be("2322");
            converted.FloatPart.Should().Be("442555");
            converted.Base.Should().Be(8);
            converted.ToString().Should().Be("02322.442555");

            converter = new OctalConverter(new OctalNumber("1234.567"));
            converted = converter.Convert();
            converted.IntegerPart.Should().Be("1234");
            converted.FloatPart.Should().Be("567");
            converted.Base.Should().Be(8);
            converted.ToString().Should().Be("01234.567");

            converter = new OctalConverter(new BinaryNumber("1111.1111"));
            converted = converter.Convert();
            converted.IntegerPart.Should().Be("17");
            converted.FloatPart.Should().Be("740000");
            converted.Base.Should().Be(8);
            converted.ToString().Should().Be("017.740000");

            converter = new OctalConverter(new HexadecimalNumber("1111.1111"));
            converted = converter.Convert();
            converted.IntegerPart.Should().Be("10421");
            converted.FloatPart.Should().Be("042104");
            converted.Base.Should().Be(8);
            converted.ToString().Should().Be("010421.042104");
        }
    }
}