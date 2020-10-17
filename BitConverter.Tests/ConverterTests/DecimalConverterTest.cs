using BitConverter.Converters;
using BitConverter.Interfaces;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.ConverterTests
{
    [TestFixture]
    public class DecimalConverterTest
    {
        [Test]
        public void Decimal_Converter_Test()
        {
            IConverter binaryConverter = new DecimalConverter(new DecimalNumber("123.456"));
            var converted = binaryConverter.Convert();
            converted.IntegerPart.Should().Be("123");
            converted.FloatPart.Should().Be("456");
            converted.Base.Should().Be(10);
            converted.ToString().Should().Be("123.456");

            binaryConverter = new DecimalConverter(new OctalNumber("123.456"));
            converted = binaryConverter.Convert();
            converted.IntegerPart.Should().Be("83");
            converted.FloatPart.Should().Be("589844");
            converted.Base.Should().Be(10);
            converted.ToString().Should().Be("83.589844");
            
            binaryConverter = new DecimalConverter(new HexadecimalNumber("123.456"));
            converted = binaryConverter.Convert();
            converted.IntegerPart.Should().Be("291");
            converted.FloatPart.Should().Be("270996");
            converted.Base.Should().Be(10);
            converted.ToString().Should().Be("291.270996");
            
            binaryConverter = new DecimalConverter(new BinaryNumber("101.111"));
            converted = binaryConverter.Convert();
            converted.IntegerPart.Should().Be("5");
            converted.FloatPart.Should().Be("875");
            converted.Base.Should().Be(10);
            converted.ToString().Should().Be("5.875");
        }
    }
}