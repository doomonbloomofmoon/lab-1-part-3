using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_3
{
    internal class Par_6
    {
        string word = "санки";
        char[,] collection = 
        { 
            { 'ф', 'е', 'и' },
            { 'м', 'о', 'с' },
            { 'г', 'ч', 'п' },
            { 'о', 'к', 'е' },
            { 'р', 'б', 'я' },
            { 'ю', 'н', 'ы' },
            { 'я', 'а', 'ж' },
            { 'е', 'э', 'о' },
        };
        public void Start()
        {
            Console.WriteLine("Массив: ");
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 3; ++j)
                    Console.Write($"{collection[i, j]}  ");
                Console.WriteLine();
            }
            Console.WriteLine($"\nСлово: {word}\n");
            var list = collection.Cast<char>().ToList();
            bool canDo()
            {
                if (word.Length > list.Count()) return false;
                foreach (var w in word)
                    if (!list.Remove(w)) return false;
                return true;
            }
            Console.Write($"Составить слово ");
            if (canDo())
            {
                Console.WriteLine("возможно");
            }
            else
            {
                Console.WriteLine("невозможно");
            }
            Console.WriteLine();
        }
    }
}

