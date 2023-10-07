using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_3
{
    internal class Par_5
    {
        string text;
        public Par_5()
        {
            this.text = "Я сошью себе черные штаны\nиз бархата голоса моего.\nЖелтую кофту из трех аршин заката.\nПо Невскому мира, по лощеным полосам его,\nпрофланирую шагом Дон-Жуана и фата.";
        }
        public Par_5(string _text)
        {
            this.text = _text;
        }
        public void Start()
        {
            int countWords = 0;
            string cleanedText = RemoveNonAlphabeticCharacters(text);
            var words = new SortedDictionary<char, int>();
            char tempKey;
            int tempValue;
            bool isBeen = false;
            string tempText = "";
            foreach (char c in cleanedText)
                tempText += char.ToLower(c);
            for (int i = 0; i < tempText.Length - 1; i++)
            {
                foreach (var word in words)
                {
                    isBeen = tempText[i] == word.Key ? true : false;
                    if (isBeen) break;
                }
                if (isBeen)
                {
                    continue;
                }
                else
                {
                    ++countWords;
                    tempKey = tempText[i];
                    tempValue = 1;
                    for (int j = i + 1; j < tempText.Length; j++)
                        if (tempText[i] == tempText[j])
                            ++tempValue;
                    words.Add(tempKey, tempValue);
                }
            }
            Console.WriteLine($"Исходный текст:\n{text}\n");
            Console.WriteLine($"Количество букв: {countWords}");
            Console.WriteLine("Сводка:");
            int tempCount = 0;
            foreach (var word in words) 
            {
                if (tempCount == 7)
                {
                    Console.WriteLine();
                    tempCount = 1;
                }
                else
                {
                    ++tempCount;
                }
                Console.Write($"{word.Key}({word.Value})\t");
            }
            Console.WriteLine("\n");
        }
        string RemoveNonAlphabeticCharacters(string text)
        {
            StringBuilder cleanedText = new StringBuilder();
            foreach (char c in text)
                if (Char.IsLetter(c))
                    cleanedText.Append(c);
            return cleanedText.ToString();
        }
    }
}
