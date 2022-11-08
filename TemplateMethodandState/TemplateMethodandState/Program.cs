using System;

namespace TemplateMethodandState 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleCrypt consoleCrypt = new ConsoleCrypt();
            consoleCrypt.Encrypt();
        }
    }
}