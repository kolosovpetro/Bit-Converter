using BitConverter.Entities;
using BitConverter.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace BitConverter.Tests.Tests
{
    [TestFixture]
    public class BinaryToStringTest
    {
        [Test]
        public void Binary_ToString_Test_1()
        {
            IEntry entry = new Entry("10101", 2);
            entry.ToString().Should().Be("10101.");
        }
        
        [Test]
        public void Binary_ToString_Test_2()
        {
            IEntry entry = new Entry("10101.010101", 2);
            entry.ToString().Should().Be("10101.010101");
        }
        
        [Test]
        public void Binary_ToString_Test_3()
        {
            IEntry entry = new Entry(".010101", 2);
            entry.ToString().Should().Be(".010101");
        }
        
        [Test]
        public void Binary_ToString_Test_4()
        {
            IEntry entry = new Entry(",010101", 2);
            entry.ToString().Should().Be(".010101");
        }
        
        [Test]
        public void Binary_ToString_Test_5()
        {
            IEntry entry = new Entry("10101,010101", 2);
            entry.ToString().Should().Be("10101.010101");
        }
    }
}