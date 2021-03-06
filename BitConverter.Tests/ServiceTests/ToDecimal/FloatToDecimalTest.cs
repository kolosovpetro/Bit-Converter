﻿using BitConverter.Numbers;
using BitConverter.Services.ToDecimal;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.ServiceTests.ToDecimal
{
    [TestFixture]
    public class FloatToDecimalTest
    {
        [Test]
        public void Float_Part_Convert_To_Decimal_Test()
        {
            FloatPartToDecimal.Convert(new OctalNumber("123.763")).Should().Be("974609");
            FloatPartToDecimal.Convert(new OctalNumber("123.123")).Should().Be("162109");
            FloatPartToDecimal.Convert(new HexadecimalNumber("123.AF")).Should().Be("683594");
            FloatPartToDecimal.Convert(new BinaryNumber("10101.10101")).Should().Be("65625");
            FloatPartToDecimal.Convert(new DecimalNumber("10101.10101")).Should().Be("10101");
            FloatPartToDecimal.Convert(new DecimalNumber("10101.123456")).Should().Be("123456");
        }
    }
}