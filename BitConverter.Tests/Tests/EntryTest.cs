using System;
using BitConverter.Exceptions;
using BitConverter.Interfaces;
using BitConverter.Models;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.Tests
{
    [TestFixture]
    public class EntryTest
    {
        [Test]
        public void Entry_Simple_Test()
        {
            INumber entry = new NumberModel("123", 10);
            entry.IntegerPart.Should().Be("123");
            entry.FloatPart.Should().BeNull();
            entry.Base.Should().Be(10);
        }

        [Test]
        public void Float_Number_Test_1()
        {
            INumber entry = new NumberModel("123.456", 10);
            entry.IntegerPart.Should().Be("123");
            entry.FloatPart.Should().Be("456");
            entry.Base.Should().Be(10);
        }

        [Test]
        public void Float_Number_Test_2()
        {
            INumber entry = new NumberModel("123,456", 10);
            entry.IntegerPart.Should().Be("123");
            entry.FloatPart.Should().Be("456");
            entry.Base.Should().Be(10);
        }

        [Test]
        public void Float_Number_Test_3()
        {
            INumber entry = new NumberModel(",456", 10);
            entry.IntegerPart.Should().BeNull();
            entry.FloatPart.Should().Be("456");
            entry.Base.Should().Be(10);
        }

        [Test]
        public void Hexadecimal_Number_Test()
        {
            INumber entry = new NumberModel(".10AF", 16);
            entry.IntegerPart.Should().BeNull();
            entry.FloatPart.Should().Be("10AF");
        }

        [Test]
        public void Exception_Test_1()
        {
            Action action = () => new NumberModel("asda.as", 10);
            action.Should().Throw<InvalidFormatException>()
                .WithMessage("Entered number has a wrong format.");
        }

        [Test]
        public void Exception_Test_2()
        {
            Action action = () => new NumberModel("01010102", 2);
            action.Should().Throw<InvalidFormatException>()
                .WithMessage("Entered number has a wrong format.");
        }

        [Test]
        public void Exception_Test_3()
        {
            Action action = () => new NumberModel("01010102", 3);
            action.Should().Throw<UnsupportedBaseException>()
                .WithMessage("Provided base is not supported.");
        }
    }
}