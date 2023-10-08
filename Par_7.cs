using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_3
{
    internal class Par_7
    {
        string input;
        public void Start()
        {
            Console.WriteLine($"Исходный текст: {input}\n");
            string cleanedString = CleanString(input);
            Console.WriteLine($"Преобразованный текст: {cleanedString}");
        }
        string CleanString(string input)
        {
            input = input.Trim();
            StringBuilder sb = new StringBuilder();
            bool isSpace = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsWhiteSpace(input[i]))
                {
                    if (!isSpace)
                    {
                        sb.Append(' ');
                        isSpace = true;
                    }
                }
                else
                {
                    sb.Append(input[i]);
                    isSpace = false;
                }
            }
            return sb.ToString();
        }

        public Par_7()
        {
            this.input = "GitHub     - веб-сервис,    который основан на      системе Git.";
        }
    }
}

/*
string CleanString(string input)
{
    input = input.Trim();
    input = string.Join(" ", input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
    return input;
}
*/