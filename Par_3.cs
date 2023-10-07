using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_3
{
    internal class Par_3
    {
        string inputString;
        public void Start()
        {
            StringBuilder foundWords = new StringBuilder();
            string[] words = inputString.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string tempWord;
            var output = new Collection<string>();
            foreach (string s in words)
            {
                tempWord = "";
                foreach (char c in s)
                    tempWord += char.ToLower(c);
                output.Add(tempWord);
            }
            foreach (string word in output)
                if (word.Length > 1 && word[0] == word[word.Length - 1])
                    foundWords.Append(word).Append(' ');
            string result = foundWords.ToString().Trim();
            Console.Write("Найденные слова: ");
            Console.WriteLine(result);
        }
        public Par_3() 
        {
            this.inputString = "Поле, окно, казан, Казак, фраза. сКос";
        }
    }
}


