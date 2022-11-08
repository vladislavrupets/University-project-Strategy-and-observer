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
    /*public abstract class Person
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
    }*/
    public interface IObserver
    {
        public void Update(ISubject subject);
    }

    public interface ISubject
    {
        public void AddObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void Notify();
    }

    public class Person : IObserver, ISubject
    {
        private string name;
        private List<LanguageKnowledge> languages;
        private List<IObserver> observers;
        private string no;
        private string answer;
        private string question;
        public Person(string name, string no)
        {
            this.name = name;
            this.no = no;
            answer = "";
            question = "";
            languages = new List<LanguageKnowledge>();
            observers = new List<IObserver>();
        }
        public void Ask(string question)
        {
            this.question = question;
            Notify();
        }
        public string Answer(string question)
        {
            foreach (LanguageKnowledge language in languages)
            {
                if (language.Answer(question) == language.yes)
                {
                    return language.yes;
                }
            }
            return no;
        }
        public void AddLanguage(LanguageKnowledge language)
        {
            languages.Add(language);
        }

        public void Update(ISubject subject)
        {
            Person person = subject as Person;
            answer = this.Answer(person.question);
        }
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }
        public int ObserverCount()
        {
            /*List<Person> persons = new List<Person>();
            foreach (var o in observers)
                persons.Add((Person)o);
            int cnt = 0;
            
            foreach (var p in persons)
            {
                cnt++;
            }*/
            return observers.Count;
        }
    }






    public abstract class LanguageKnowledge
    {
        protected string[] vocabulary;
        public string yes;
        public string no;
        public string Answer(string question)
        {
            string[] words = question.Split(' ');
            bool found = false;
            foreach (string qWord in words)
            {
                foreach (string vWord in vocabulary)
                {
                    if (qWord == vWord)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                    break;
            }
            if (found)
                return yes;
            else
                return no;
        }
    }
    public class EnglishKnowledge : LanguageKnowledge
    {
        public EnglishKnowledge()
        {
            vocabulary = new string[] { "table", "apple", "tree" };
            yes = "yes";
            no = "no";
        }
    }
    public class UkrainianKnowledge : LanguageKnowledge
    {
        public UkrainianKnowledge()
        {
            vocabulary = new string[] { "стіл", "яблуко", "дерево" };
            yes = "так";
            no = "ні";
        }
    }
    public class GermanKnowledge : LanguageKnowledge
    {
        public GermanKnowledge()
        {
            vocabulary = new string[] { "Tisch", "Apfel", "Baum" };
            yes = "ja"; no = "nein";
        }
    }
}