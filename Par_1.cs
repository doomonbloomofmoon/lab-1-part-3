using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_3
{
    internal class Par_1
    {
        public void Start()
        {
            string inputMessage = "Ночь. улица. Фонарь. аптека...";
            string outputMessage = "";
            for (int i = 0; i < inputMessage.Length; i++)
            {
                try
                {
                    char currentChar = inputMessage[i];
                    bool isLower = char.IsLower(currentChar) ? true : false;
                    bool precedesPoint = inputMessage[i - 2] == '.' ? true : false;
                    bool precedesQuestionMark = inputMessage[i - 2] == '?' ? true : false;
                    bool precedesExclamationMark = inputMessage[i - 2] == '!' ? true : false;
                    bool beenPunctuationSymbol = precedesPoint || precedesQuestionMark ? true : false;
                    beenPunctuationSymbol = beenPunctuationSymbol || precedesExclamationMark ? true : false;
                    if (isLower && beenPunctuationSymbol)
                        currentChar = char.ToUpper(currentChar);
                    outputMessage += currentChar;
                }
                catch 
                {
                    outputMessage += inputMessage[i];
                }
            }
            Console.WriteLine($"Входящее сообщение: {inputMessage}");
            Console.WriteLine($"Выходящее сообщение: {outputMessage}");
        }
    }
}


