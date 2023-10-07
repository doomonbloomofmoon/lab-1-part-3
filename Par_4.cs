using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_3
{
    internal class Par_4
    {
        string inputString;
        string wordToFind;
        public void Start()
        {
            int count = 0;
            int startIndex = 0;
            for (; (startIndex = inputString.IndexOf(wordToFind, startIndex)) != -1; count++)
                startIndex += wordToFind.Length;
            Console.WriteLine($"Исходный текст:\n{inputString}\n");
            Console.WriteLine($"Искомое слово '{wordToFind}' встречается {count} раз.");
        }
        public Par_4()
        {
            this.inputString = "C# - объектно-ориентированный язык программирования общего назначения.\nРазработан в 1998–2001 годах группой инженеров компании Microsoft под руководством Андерса Хейлсберга и Скотта Вильтаумота как язык разработки приложений для платформы Microsoft .NET Framework и .NET Core.";
            this.wordToFind = "язык";
        }
    }
}


