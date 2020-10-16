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
            IntegerPartToDecimal.Convert(new BinaryNumber("11010")).Should().Be("26");
            IntegerPartToDecimal.Convert(new BinaryNumber("1010101")).Should().Be("85");
            IntegerPartToDecimal.Convert(new OctalNumber("145")).Should().Be("101");
            IntegerPartToDecimal.Convert(new OctalNumber("00012")).Should().Be("10");
            IntegerPartToDecimal.Convert(new DecimalNumber("1010101")).Should().Be("1010101");
            IntegerPartToDecimal.Convert(new HexadecimalNumber("AF.")).Should().Be("175");
            IntegerPartToDecimal.Convert(new HexadecimalNumber("FD.")).Should().Be("253");
            IntegerPartToDecimal.Convert(new HexadecimalNumber("10AF.")).Should().Be("4271");
            IntegerPartToDecimal.Convert(new HexadecimalNumber("10AF")).Should().Be("4271");
        }
    }
}