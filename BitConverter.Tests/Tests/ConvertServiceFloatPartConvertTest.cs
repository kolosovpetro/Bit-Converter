using BitConverter.Entities;
using BitConverter.Services;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.Tests
{
    [TestFixture]
    public class ConvertServiceFloatPartConvertTest
    {
        [Test]
        public void Convert_Float_Part_Test()
        {
            var test1 = ConverterService.ConvertFloatPartToDecimal(new Entry("123.763", 8));
            double.Parse(test1).Should().Be(0.9746);
            var test2 = ConverterService.ConvertFloatPartToDecimal(new Entry("123.123", 8));
            double.Parse(test2).Should().Be(0.1621);
            var test3 = ConverterService.ConvertFloatPartToDecimal(new Entry("123.AF", 16));
            double.Parse(test3).Should().Be(0.6836);
            var test4 = ConverterService.ConvertFloatPartToDecimal(new Entry("10101.10101", 2));
            double.Parse(test4).Should().Be(0.6562);
        }
    }
}