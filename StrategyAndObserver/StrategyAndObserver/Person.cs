using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAndObserver
{
    /*public class Person
    {
        public Person(string name)
        { }
        public string Ask()
        {
            return "something";
        }
        public string Answer(string question)
        {
            return "Yes";
        }
    }*/

    /*public abstract class Person
    {
        private string name;
        public Person(string name) { this.name = name; }
        public string Ask() { return "something"; }
        public abstract string Answer(string question);
    }
    public class EnglishPerson : Person
    {
        private string[] vocabulary = new string[] { "table", "apple", "tree" };
        private string yes = "yes";
        private string no = "no";
        public EnglishPerson(string name) : base(name) { }
        public override string Answer(string question)
        {
            string[] words = question.Split(' ');
            bool found = false;
            foreach (string qWord in words)
            {
                foreach (string vWord in vocabulary)
                {
                    if (qWord == vWord)
                    { found = true; break; }
                }
                if (found) break;
            }
            if (found) return yes;
            else return no;
        }
    }*/
    public abstract class Person
    {
        private string name;
        protected string[] vocabulary;
        protected string yes;
        protected string no;
        public Person(string name) { this.name = name; }
        public string Ask() { return "something"; }
        public string Answer(string question)
        {
            string[] words = question.Split(' ');
            bool found = false;
            foreach (string qWord in words)
            {
                foreach (string vWord in vocabulary)
                {
                    if (qWord == vWord)
                    { found = true; break; }
                }
                if (found) break;
            }
            if (found) return yes;
            else return no;
        }
    }
    public class EnglishPerson : Person
    {
        public EnglishPerson(string name) : base(name)
        {
            vocabulary = new string[] { "table", "apple", "tree" };
            yes = "yes"; no = "no";
        }
    }
    public class UkrainianPerson : Person
    {
        public UkrainianPerson(string name) : base(name)
        {
            vocabulary = new string[] { "стіл", "яблуко", "дерево" };
            yes = "так"; no = "ні";
        }
    }
    public class GermanPerson : Person
    {
        public GermanPerson(string name) : base(name)
        {
            vocabulary = new string[] { "Tisch", "Apfel", "Baum" };
            yes = "ja"; no = "nein";
        }
    }


}
