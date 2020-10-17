using BitConverter.Converters;
using BitConverter.Interfaces;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.ConverterTests
{
    [TestFixture]
    public class BinaryConverterTest
    {
        [Test]
        public void Binary_Converter_Test()
        {
            IConverter binaryConverter = new BinaryConverter(new DecimalNumber("123.456"));
            var converted = binaryConverter.Convert();
            converted.IntegerPart.Should().Be("1111011");
            converted.FloatPart.Should().Be("011101");
            converted.Base.Should().Be(2);
            converted.ToString().Should().Be("1111011.011101");

            binaryConverter = new BinaryConverter(new OctalNumber("123.456"));
            converted = binaryConverter.Convert();
            converted.IntegerPart.Should().Be("1010011");
            converted.FloatPart.Should().Be("100101");
            converted.Base.Should().Be(2);
            converted.ToString().Should().Be("1010011.100101");
            
            binaryConverter = new BinaryConverter(new HexadecimalNumber("123.456"));
            converted = binaryConverter.Convert();
            converted.IntegerPart.Should().Be("100100011");
            converted.FloatPart.Should().Be("010001");
            converted.Base.Should().Be(2);
            converted.ToString().Should().Be("100100011.010001");
            
            binaryConverter = new BinaryConverter(new BinaryNumber("101.111"));
            converted = binaryConverter.Convert();
            converted.IntegerPart.Should().Be("101");
            converted.FloatPart.Should().Be("111");
            converted.Base.Should().Be(2);
            converted.ToString().Should().Be("101.111");
        }
    }
}