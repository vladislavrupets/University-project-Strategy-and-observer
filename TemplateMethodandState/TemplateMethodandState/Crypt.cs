using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandState
{
    public abstract class Crypt
    {
        public void Encrypt()
        {
            //SetUpAlgorithm();
            string content = GetString();
            int key = GetKey();
            string encContent = ApplyEncryption(content, key);
            SaveString(encContent);
        }
        //public abstract void SetUpAlgorithm();
        public abstract string GetString();
        public abstract void SaveString(string encContent);
        public virtual int GetKey()
        {
            Console.WriteLine("Введите ключ");
            string key = Console.ReadLine();
            return Convert.ToInt32(key);

        }
        public virtual string ApplyEncryption(string content, int key)
        {
            CaesarCipher caesarCipher = new CaesarCipher();
            return caesarCipher.Encrypt(content, key);            
        }
        public virtual string ApplyDecryption(string content, int key)
        {
            CaesarCipher caesarCipher = new CaesarCipher();
            return caesarCipher.Decrypt(content, key);
        }
    }
}
