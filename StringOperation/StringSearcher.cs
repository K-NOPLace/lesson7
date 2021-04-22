using System;
using System.Collections.Generic;

namespace StringS
{
    class StringSearcher
    {
        public static bool w = false;
        public delegate void Word(string word);
        public event Word Print;
        public void Search(List<string> str)
        {
            Console.WriteLine("Какое слово проверим?");
            string word = Console.ReadLine();
            foreach (string p in str)
            {
                if (word == p)
                {
                    w = true;
                }
            }
            if (w == true)
            {
                Print?.Invoke($"``{word}`` eсть в списке");
            }
            else
            {
                Print?.Invoke("Нет в списке");
            }
        }
    }
}
