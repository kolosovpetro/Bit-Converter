using BitConverter.Auxiliaries;
using BitConverter.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.Tests
{
    [TestFixture]
    public class ConverterServiceIntegerPartConvertTest
    {
        // hexadecimal fails, need to revise regex
        
        [Test]
        public void Binary_To_Decimal_Integer_Convert_Test()
        {
            ConverterService.ConvertIntegerPartToDecimal(new Entry("11010", 2)).Should().Be("26");
            ConverterService.ConvertIntegerPartToDecimal(new Entry("1010101", 2)).Should().Be("85");
            ConverterService.ConvertIntegerPartToDecimal(new Entry("145", 8)).Should().Be("101");
            ConverterService.ConvertIntegerPartToDecimal(new Entry("00012", 8)).Should().Be("10");
            ConverterService.ConvertIntegerPartToDecimal(new Entry("AF.", 16)).Should().Be("175");
            ConverterService.ConvertIntegerPartToDecimal(new Entry("FD.", 16)).Should().Be("253");
            ConverterService.ConvertIntegerPartToDecimal(new Entry("10AF.", 16)).Should().Be("4271");
        }
    }
}