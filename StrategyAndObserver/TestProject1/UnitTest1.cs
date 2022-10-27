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

        /*[Test]
        public void Test1()
        {
            Person p1 = new Person("A");
            Person p2 = new Person("B");
            Person p3 = new Person("C");
            string question = p1.Ask();
            Assert.AreEqual("Yes", p2.Answer(question));
            Assert.AreEqual("Yes", p3.Answer(question));

        }*/
        /*[Test]
        public void TestMethod2()
        {
            Person p = new EnglishPerson("A");
            Assert.AreEqual("yes", p.Answer("peace apple nose"));
            Assert.AreEqual("no", p.Answer("milk coffee beer"));
        }*/
        [Test]
        public void TestMethod3() //there are different nationalities
        {
            Person p1 = new EnglishPerson("A");
            Person p2 = new UkrainianPerson("B");
            Person p3 = new GermanPerson("A");
            Assert.AreEqual("yes", p1.Answer("peace apple nose"));
            Assert.AreEqual("í³", p2.Answer("peace apple nose"));
            Assert.AreEqual("nein", p3.Answer("peace apple nose"));
        }

    }
}