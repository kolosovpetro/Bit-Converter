using System;
using BitConverter.Entities;
using BitConverter.Exceptions;
using BitConverter.Interfaces;
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
            IEntry entry = new Entry("123", 10);
            entry.IntegerPart.Should().Be("123");
            entry.FloatPart.Should().BeNull();
            entry.Base.Should().Be(10);
        }

        [Test]
        public void Float_Number_Test_1()
        {
            IEntry entry = new Entry("123.456", 10);
            entry.IntegerPart.Should().Be("123");
            entry.FloatPart.Should().Be("456");
            entry.Base.Should().Be(10);
        }

        [Test]
        public void Float_Number_Test_2()
        {
            IEntry entry = new Entry("123,456", 10);
            entry.IntegerPart.Should().Be("123");
            entry.FloatPart.Should().Be("456");
            entry.Base.Should().Be(10);
        }

        [Test]
        public void Float_Number_Test_3()
        {
            IEntry entry = new Entry(",456", 10);
            entry.IntegerPart.Should().BeNull();
            entry.FloatPart.Should().Be("456");
            entry.Base.Should().Be(10);
        }

        [Test]
        public void Hexadecimal_Number_Test()
        {
            IEntry entry = new Entry(".10AF", 16);
            entry.IntegerPart.Should().BeNull();
            entry.FloatPart.Should().Be("10AF");
        }

        [Test]
        public void Exception_Test_1()
        {
            Action action = () => new Entry("asda.as", 10);
            action.Should().Throw<InvalidFormatException>()
                .WithMessage("Entered number has a wrong format.");
        }

        [Test]
        public void Exception_Test_2()
        {
            Action action = () => new Entry("01010102", 2);
            action.Should().Throw<InvalidFormatException>()
                .WithMessage("Entered number has a wrong format.");
        }

        [Test]
        public void Exception_Test_3()
        {
            Action action = () => new Entry("01010102", 3);
            action.Should().Throw<UnsupportedBaseException>()
                .WithMessage("Provided base is not supported.");
        }
    }
}