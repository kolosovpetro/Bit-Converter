﻿using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.HexadecimalNumberTests
{
    [TestFixture]
    public class HexadecimalFloatDotSeparatedTest
    {
        [Test]
        public void Hexadecimal_Float_Dot_Separated_Test()
        {
            INumber number = new NumberModel("AD.FD", 16);
            number.IntegerPart.Should().Be("AD");
            number.FloatPart.Should().Be("FD");
            number.Base.Should().Be(16);
            
            number = new HexadecimalNumber("AD.FD");
            number.IntegerPart.Should().Be("AD");
            number.FloatPart.Should().Be("FD");
            number.Base.Should().Be(16);
        }
    }
}