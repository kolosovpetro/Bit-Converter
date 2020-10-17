using BitConverter.Converters;
using BitConverter.Interfaces;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.ConverterTests
{
    [TestFixture]
    public class HexadecimalConverterTest
    {
        [Test]
        public void Hexadecimal_Converter_Test()
        {
            IConverter hexConverter = new HexadecimalConverter(new BinaryNumber("101010101111.1010"));
            var converted = hexConverter.Convert();
            converted.IntegerPart.Should().Be("AAF");
            converted.FloatPart.Should().Be("A00000");
            converted.Base.Should().Be(16);
            converted.ToString().Should().Be("0xAAF.A00000");
            
            hexConverter = new HexadecimalConverter(new DecimalNumber("101010101111.1010"));
            converted = hexConverter.Convert();
            converted.IntegerPart.Should().Be("1784ABD377");
            converted.FloatPart.Should().Be("19DB22");
            converted.Base.Should().Be(16);
            converted.ToString().Should().Be("0x1784ABD377.19DB22");
            
            hexConverter = new HexadecimalConverter(new OctalNumber("101010101111.1010"));
            converted = hexConverter.Convert();
            converted.IntegerPart.Should().Be("208208249");
            converted.FloatPart.Should().Be("207FFD");
            converted.Base.Should().Be(16);
            converted.ToString().Should().Be("0x208208249.207FFD");
            
            hexConverter = new HexadecimalConverter(new HexadecimalNumber("101010101111.1010"));
            converted = hexConverter.Convert();
            converted.IntegerPart.Should().Be("101010101111");
            converted.FloatPart.Should().Be("1010");
            converted.Base.Should().Be(16);
            converted.ToString().Should().Be("0x101010101111.1010");
        }
    }
}