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
            entry.DecimalPart.Should().Be("0");
            entry.Base.Should().Be(10);
        }

        [Test]
        public void Float_Number_Test_1()
        {
            IEntry entry = new Entry("123.456", 10);
            entry.IntegerPart.Should().Be("123");
            entry.DecimalPart.Should().Be("456");
            entry.Base.Should().Be(10);
        }

        [Test]
        public void Float_Number_Test_2()
        {
            IEntry entry = new Entry("123,456", 10);
            entry.IntegerPart.Should().Be("123");
            entry.DecimalPart.Should().Be("456");
            entry.Base.Should().Be(10);
        }

        [Test]
        public void Float_Number_Test_3()
        {
            IEntry entry = new Entry(",456", 10);
            entry.IntegerPart.Should().Be("0");
            entry.DecimalPart.Should().Be("456");
            entry.Base.Should().Be(10);
        }

        [Test]
        public void Exception_Test()
        {
            Action action = () => new Entry("asda.as", 10);
            action.Should().Throw<InvalidFormatException>()
                .WithMessage("Entered number has a wrong format.");
        }
    }
}