using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdevi2
{
    public class StackNode
    {
        public string[] Kelimeler;
        public string Cumle;
        public int KelimeSayisi;
        public StackNode Next;

        public StackNode(string str)
        {
            Cumle = str.ToLower();
            KelimeSayisi = 0;

            string[] Isaretler = {".", ",", ";", ":", "!", "?", "-", ":", "'", "/", "(", ")", "[", "]", "{", "}", "_", "|", "=", "+", "*", "<", ">", "~", "&", "%", "#", "$", "£", "^", "é"};

            foreach (string item in Isaretler)
            {
                Cumle = Cumle.Replace(item, "");
            }

            Kelimeler = Cumle.Split(' ');
            KelimeSayisi = Kelimeler.Length;
        }
    }
}
