using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_3
{
    internal class Par_11
    {
        string A;
        string B;
        public void Start()
        {
            string answer = CanConstruct() ? "можно" : "нельзя";
            Console.WriteLine($"Из букв, входящих в слово '{A}' {answer}(!) составить слово '{B}'");
        }
        bool CanConstruct()
        {
            StringBuilder sb = new StringBuilder(A);
            foreach (char c in B)
            {
                int index = sb.ToString().IndexOf(c);
                if (index == -1) return false;
                sb.Remove(index, 1);
            }
            return true;
        }
        public Par_11()
        {
            this.A = "диалектика";
            this.B = "клетка";
        }
    }
}


