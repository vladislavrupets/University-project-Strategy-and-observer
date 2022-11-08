using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    internal class ConsoleCrypt : Crypt
    {
        public ConsoleCrypt()
        {

        }
        public override string GetString()
        {
            Console.WriteLine("Введите строку которую нужно зашифровать");
            string content = Console.ReadLine();
            return content;
        }

        public override void SaveString(string encContent)
        {
            Console.WriteLine("Зашифрованная строка");
            Console.WriteLine(encContent);
        }
    }
}
