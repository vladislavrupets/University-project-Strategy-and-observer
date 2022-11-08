using NUnit.Framework;
using TemplateMethodandState;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMethod1()//Caesar cipher
        {
            CaesarCipher caesarCipher = new CaesarCipher();
            Assert.AreEqual("¬доснс", caesarCipher.Encrypt("€блоко", 3));
        }
    }
}