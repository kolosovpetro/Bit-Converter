using BitConverter.Models;
using BitConverter.Services;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.Tests
{
    [TestFixture]
    public class ConverterServiceIntegerPartConvertTest
    {
        // hexadecimal fails, need to revise regex
        
        [Test]
        public void Integer_Part_Convert_To_Decimal()
        {
            ConverterService.ConvertIntegerPartToDecimal(new NumberModel("11010", 2)).Should().Be("26");
            ConverterService.ConvertIntegerPartToDecimal(new NumberModel("1010101", 2)).Should().Be("85");
            ConverterService.ConvertIntegerPartToDecimal(new NumberModel("145", 8)).Should().Be("101");
            ConverterService.ConvertIntegerPartToDecimal(new NumberModel("145", 10)).Should().Be("145");
            ConverterService.ConvertIntegerPartToDecimal(new NumberModel("00012", 8)).Should().Be("10");
            ConverterService.ConvertIntegerPartToDecimal(new NumberModel("AF.", 16)).Should().Be("175");
            ConverterService.ConvertIntegerPartToDecimal(new NumberModel("FD.", 16)).Should().Be("253");
            ConverterService.ConvertIntegerPartToDecimal(new NumberModel("10AF.", 16)).Should().Be("4271");
        }

        [Test]
        public void Integer_Part_Convert_From_Decimal()
        {
            ConverterService.ConvertIntegralPartFromDecimal(new NumberModel("1000", 10), 2)
                .Should().Be("1111101000");
            ConverterService.ConvertIntegralPartFromDecimal(new NumberModel("243", 10), 8)
                .Should().Be("363");
            ConverterService.ConvertIntegralPartFromDecimal(new NumberModel("1000", 10), 16)
                .Should().Be("3E8");
            ConverterService.ConvertIntegralPartFromDecimal(new NumberModel("123131", 10), 16)
                .Should().Be("1E0FB");
        }
    }
}