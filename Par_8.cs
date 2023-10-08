using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_3
{
    internal class Par_8
    {
        string inputString;
        public void Start()
        {
            Console.WriteLine($"Исходный текст: \n{inputString}");
            int length = 4;
            var charsToRemove = new string[] { ",", ".", "!", "?" };
            foreach (var c in charsToRemove)
                inputString = inputString.Replace(c, string.Empty);
            string temp = "";
            foreach (var c in inputString)
                temp += char.ToLower(c);
            inputString = temp;
            string[] words = inputString.Split(' ');
            var filteredWords = words.Where(w => w.Length == length).OrderBy(w => w).ToArray();
            Console.WriteLine($"\nБыли найдены следующие слова с заданной длинной ({length}):");
            foreach (string word in filteredWords)
                Console.Write($"{word} ");
            Console.WriteLine();
        }
        public Par_8()
        {
            this.inputString = "Море, солнце, волны, луна, песок, лужа";
        }
    }
}


