using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_3
{
    internal class Par_10
    {
        string text;
        public void Start()
        {
            string[] sentences = text.Split(new[] { '.', '!' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            foreach (string sentence in sentences)
            {
                string[] words = sentence.Trim().Split(' ');

                StringBuilder editedSentence = new StringBuilder();

                string? prevWord = null;

                foreach (string word in words)
                {
                    if (word != prevWord)
                    {
                        editedSentence.Append(word).Append(' ');
                    }

                    prevWord = word;
                }

                result.Append(editedSentence.ToString().Trim()).Append(". ");
            }

            string editedText = result.ToString().Trim();
            Console.WriteLine(editedText);
        }

        public Par_10() 
        {
            this.text = "Нелепо приниматься за за за дело, когда нет сил сил на него. Испортишь дело дело - выйдет мерзость.";
        }
    }
}
