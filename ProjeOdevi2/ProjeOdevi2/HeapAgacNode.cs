using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdevi2
{
    public class HeapAgacNode
    {
        public string Kelime;
        public int KullanimSayi;
        public int[] Konum;

        public HeapAgacNode(string str)
        {
            Kelime = str;
            KullanimSayi = 1;
        }
    }
}
