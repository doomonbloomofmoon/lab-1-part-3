using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_3
{
    internal class Par_2
    {
        string input;
        int count;
        public void Start()
        {
            StringBuilder uniqueChars = new StringBuilder();
            string output = "";
            foreach (char c in input)
            {
                if (c == ' ' || c == '.' || c == ',' || c == '!' || c == '?')
                    continue;
                output += char.ToLower(c);
            }
            foreach (char c in output)
                if (uniqueChars.ToString().IndexOf(c) == -1)
                    uniqueChars.Append(c);
            Console.WriteLine($"Сообщение: {input}");
            count = uniqueChars.Length;
            Console.WriteLine($"Количество уникальных символов: {count}");
            Console.Write("Уникальные символы:");
            for (int i = 0; i < count; i++)
                Console.Write($" {uniqueChars[i]}");
            Console.WriteLine();
        }
        public Par_2()
        {
            this.input = "Дней бык пег. Медленна лет арба. Наш бог бег. Сердце наш барабан.";
        }
    }
}


