using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdevi2
{
    public class HashEntry
    {
        public string Anahtar;
        public HashNode Head;
        public int Boyut;

        public HashEntry()
        {
            Boyut = 0;
        }

        public void Insert(HashNode hsnd)
        {
            HashNode tmp = Head;

            if (tmp == null)
            {
                Head = hsnd;
            }
            else
            {
                while (tmp != null)
                {
                    tmp = tmp.Next;
                }
                tmp = hsnd;
                tmp.Next = Head;
                Head = tmp;
            }
            Boyut += 1;
        }
    }
}
