using System;
using System.Collections.Generic;

namespace StringS
{
    class Program
    {
        static void Main(string[] args)
        {
            StringSearcher word = new StringSearcher();
            word.Print += DisplayMessage;
            string p = null;
            Console.WriteLine("Ручное заполнение списка");
            Console.WriteLine("Для выхода введите `` + ``");
            List<string> str = new List<string>();
            while (p != "+")
            {
                p = Console.ReadLine();
                str.Add(p);
            }
            word.Search(str);
        }
        private static void DisplayMessage(string word)
        {
            Console.WriteLine(word);
        }
    }
}
