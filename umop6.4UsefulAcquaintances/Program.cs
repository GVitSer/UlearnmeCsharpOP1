using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop6o4UsefulAcquaintances
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts =new List <string> { "Ваня:ivan@grozniy.ru", "Ваня:v@mail.ru", 
                "Ваня:vanechka@domain.com", "Вася:vasiliy@gmail.com", "Саша:a@lex.ru", "Саша:alex@nd.ru", 
                "Саша:alexandr@yandex.ru", "Саша:sasha1995@sasha.ru", "Паша:p@p.ru", 
                "Паша:pavel.egorov@urfu.ru"};
            OptimizeContacts(contacts);
            Console.ReadKey();
        }
        private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {
            var dictionary = new Dictionary<string, List<string>>();
            foreach (var e in contacts)
            {
                var nameEmail = e.Split(':');
                var key = e.Substring(0, Math.Min(2, nameEmail[0].Length));
                if (!dictionary.ContainsKey(key))
                {
                    dictionary[key] = new List<string>();
                }
                dictionary[key].Add(e);
            }
            return dictionary;
        }
    }
}
