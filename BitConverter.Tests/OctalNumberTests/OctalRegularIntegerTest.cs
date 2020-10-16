﻿using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Numbers;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.OctalNumberTests
{
    [TestFixture]
    public class OctalIntegerTest
    {
        [Test]
        public void Octal_Integer_Test()
        {
            INumber number = new NumberModel("12347", 8);
            number.IntegerPart.Should().Be("12347");
            number.FloatPart.Should().Be("0");
            number.Base.Should().Be(8);
            
            number = new OctalNumber("12347");
            number.IntegerPart.Should().Be("12347");
            number.FloatPart.Should().Be("0");
            number.Base.Should().Be(8);
        }
    }
}