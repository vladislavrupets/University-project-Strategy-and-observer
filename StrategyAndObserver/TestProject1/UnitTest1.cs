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


        /*public void Test1()
        {
            Person p1 = new Person("A");
            Person p2 = new Person("B");
            Person p3 = new Person("C");
            string question = p1.Ask();
            Assert.AreEqual("Yes", p2.Answer(question));
            Assert.AreEqual("Yes", p3.Answer(question));

        }*/
        /*
        public void TestMethod2()
        {
            Person p = new EnglishPerson("A");
            Assert.AreEqual("yes", p.Answer("peace apple nose"));
            Assert.AreEqual("no", p.Answer("milk coffee beer"));
        }*/
        /*public void TestMethod3() //there are different nationalities
        {
            Person p1 = new EnglishPerson("A");
            Person p2 = new UkrainianPerson("B");
            Person p3 = new GermanPerson("A");
            Assert.AreEqual("yes", p1.Answer("peace apple nose"));
            Assert.AreEqual("ні", p2.Answer("peace apple nose"));
            Assert.AreEqual("nein", p3.Answer("peace apple nose"));
        }*/
        [Test]
        public void TestMethod4() //Man can know some languages
        {
            LanguageKnowledge ek = new EnglishKnowledge();
            LanguageKnowledge uk = new UkrainianKnowledge();
            LanguageKnowledge gk = new GermanKnowledge();
            Person p1 = new Person("A", "dont know");
            p1.AddLanguage(ek);
            p1.AddLanguage(uk);
            Assert.AreEqual("yes", p1.Answer("peace apple nose"));
            Assert.AreEqual("так", p1.Answer("мир яблуко нос"));
            Assert.AreEqual("dont know", p1.Answer("Welt Apfel Nase"));
            Assert.AreEqual("dont know", p1.Answer("xxx yyy"));
        }
        [Test]
        public void TestMethod5()
        {
            LanguageKnowledge ek = new EnglishKnowledge();
            LanguageKnowledge uk = new UkrainianKnowledge();
            LanguageKnowledge gk = new GermanKnowledge();
            Person p1 = new Person("A", "dont know");
            p1.AddLanguage(ek);
            Person p2 = new Person("B", "dont know");
            p2.AddLanguage(ek);
            Person p3 = new Person("C", "dont know");
            p3.AddLanguage(ek);
            Person p4 = new Person("D", "dont know");
            p4.AddLanguage(uk);
            p1.AddObserver(p2);
            p1.AddObserver(p3);
            p1.AddObserver(p4);
            p1.Ask("peace apple nose");

            Assert.AreEqual(3,p1.ObserverCount());
        }
    }
}