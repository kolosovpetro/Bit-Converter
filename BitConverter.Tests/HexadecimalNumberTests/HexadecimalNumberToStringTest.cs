using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.HexadecimalNumberTests
{
    [TestFixture]
    public class HexadecimalNumberToStringTest
    {
        [Test]
        public void Hexadecimal_Number_To_String_Test()
        {
            new HexadecimalNumber(".AF").ToString().Should().Be("0x0.AF");
            new HexadecimalNumber("0.AF").ToString().Should().Be("0x0.AF");
            new HexadecimalNumber("1FD.").ToString().Should().Be("0x1FD.0");
            new HexadecimalNumber("1FD.0").ToString().Should().Be("0x1FD.0");
            new HexadecimalNumber("1FD").ToString().Should().Be("0x1FD.0");
            
            // separator comma doesnt match regex
            
            // new HexadecimalNumber(",AF").ToString().Should().Be("0x0.AF");
            // new HexadecimalNumber("0,AF").ToString().Should().Be("0x0.AF");
            
            
        }
    }
}