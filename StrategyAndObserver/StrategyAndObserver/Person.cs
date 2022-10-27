using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAndObserver
{
    public class Person
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

    }
}
