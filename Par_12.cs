using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_3
{
    internal class Par_12
    {
        string input = "Дана строка, содержащая текст на русском языке...";
        string wordToReplace = "русском";
        string newWord = "любом";

        public void Start()
        {
            Console.WriteLine($"Исходный текст:\n{input}\n");
            Console.WriteLine($"Слово \'{wordToReplace}\' меняем на \'{newWord}\'..\n");
            string replacedString = input.Replace(wordToReplace, newWord);
            Console.WriteLine($"Отредактированный текст:\n{replacedString}");
        }
    }
}


