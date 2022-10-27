using NUnit.Framework;
using StrategyAndObserver;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Person p1 = new Person("A");
            Person p2 = new Person("B");
            Person p3 = new Person("C");
            string question = p1.Ask();
            Assert.AreEqual("Yes", p2.Answer(question));
            Assert.AreEqual("Yes", p3.Answer(question));

        }
    }
}