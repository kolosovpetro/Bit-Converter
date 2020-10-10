using BitConverter.Converters;
using BitConverter.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.Tests
{
    [TestFixture]
    public class BinaryConverterTest
    {
        [Test]
        public void Convert_From_Decimal_To_Binary_Integer()
        {
            IConverter binaryConverter = new BinaryConverter();
            binaryConverter.Convert("26", 10).Should().Be("11010");
        }
    }
}