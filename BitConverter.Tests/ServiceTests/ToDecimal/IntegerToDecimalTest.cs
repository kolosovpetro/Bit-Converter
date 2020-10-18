using BitConverter.Numbers;
using BitConverter.Services.ToDecimal;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.ServiceTests.ToDecimal
{
    [TestFixture]
    public class IntegerToDecimalTest
    {
        [Test]
        public void Integer_To_Decimal_Test()
        {
            IntegerPartToDecimal.Convert(new BinaryNumber("11010.0")).Should().Be("26");
            IntegerPartToDecimal.Convert(new BinaryNumber("1010101.0")).Should().Be("85");
            IntegerPartToDecimal.Convert(new OctalNumber("145.0")).Should().Be("101");
            IntegerPartToDecimal.Convert(new OctalNumber("00012.0")).Should().Be("10");
            IntegerPartToDecimal.Convert(new DecimalNumber("1010101.0")).Should().Be("1010101");
            IntegerPartToDecimal.Convert(new HexadecimalNumber("AF.0")).Should().Be("175");
            IntegerPartToDecimal.Convert(new HexadecimalNumber("FD.0")).Should().Be("253");
            IntegerPartToDecimal.Convert(new HexadecimalNumber("10AF.0")).Should().Be("4271");
            IntegerPartToDecimal.Convert(new HexadecimalNumber("10AF.0")).Should().Be("4271");
        }
    }
}