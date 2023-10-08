using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_3
{
    internal class Par_9
    {
        string input;
        public void Start()
        {
            Console.WriteLine($"Введенная строка: \n{input}\n");
            string[] sentences = input.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string? commonWord = GetCommonWord(sentences);
            if (!string.IsNullOrEmpty(commonWord))
            {
                Console.WriteLine($"Слово \'{commonWord}\' встречается в каждом предложении.");
            }
            else
            {
                Console.WriteLine("Слово, вопторяющееся в каждом предложении не найдено.");
            }
        }
        string? GetCommonWord(string[] sentences)
        {
            if (sentences.Length == 0) return null;
            StringBuilder commonWord = new StringBuilder();
            string[] words = sentences[0].Split(new char[] { ' ', ',', ';', ':', '-', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                bool isCommon = true;
                for (int i = 1; i < sentences.Length; i++)
                    if (!sentences[i].Contains(word))
                    {
                        isCommon = false;
                        break;
                    }
                if (isCommon)
                {
                    commonWord.Append(word);
                    commonWord.Append(" ");
                }
            }
            return commonWord.ToString().Trim();
        }
        public Par_9() 
        {
            this.input = "Сколько я не ходил - не смог найти. Когда я это потерял? И что я потерял?";
        }
    }
}


