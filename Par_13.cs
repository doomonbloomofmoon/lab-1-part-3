using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_3
{
    internal class Par_13
    {
        string sentence;
        public void Start()
        {
            Console.WriteLine($"Переменная: {sentence}");
            Console.WriteLine("Возможные варианты:");
            string[] words = sentence.Split('_');
            Permute(words, 0);
            Console.WriteLine();
        }
        void Permute(string[] words, int currentIndex)
        {
            if (currentIndex == words.Length - 1)
            {
                Console.WriteLine(string.Join(" ", words));
            }
            else
            {
                for (int i = currentIndex; i < words.Length; i++)
                {
                    Swap(ref words[currentIndex], ref words[i]);
                    Permute(words, currentIndex + 1);
                    Swap(ref words[currentIndex], ref words[i]);
                }
            }
        }
        void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
        public Par_13(string _sentence)
        {
            this.sentence = _sentence;
        }
        public Par_13()
        {
            this.sentence = "название_новой_переменной";
        }
    }
}


