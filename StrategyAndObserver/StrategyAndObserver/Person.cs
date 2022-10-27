using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAndObserver
{
    public abstract class Person
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
    }

}
