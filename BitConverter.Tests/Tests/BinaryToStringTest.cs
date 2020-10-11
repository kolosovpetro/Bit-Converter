using BitConverter.Interfaces;
using BitConverter.Models;
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
            INumber entry = new NumberModel("10101", 2);
            entry.ToString().Should().Be("10101.");
        }
        
        [Test]
        public void Binary_ToString_Test_2()
        {
            INumber entry = new NumberModel("10101.010101", 2);
            entry.ToString().Should().Be("10101.010101");
        }
        
        [Test]
        public void Binary_ToString_Test_3()
        {
            INumber entry = new NumberModel(".010101", 2);
            entry.ToString().Should().Be(".010101");
        }
        
        [Test]
        public void Binary_ToString_Test_4()
        {
            INumber entry = new NumberModel(",010101", 2);
            entry.ToString().Should().Be(".010101");
        }
        
        [Test]
        public void Binary_ToString_Test_5()
        {
            INumber entry = new NumberModel("10101,010101", 2);
            entry.ToString().Should().Be("10101.010101");
        }
    }
}