using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdevi2
{
    public class HashMap
    {
        public string Alfabe = "qwertyuıopğüasdfghjklşizxcvbnmöç";
        public HashEntry[] HashDizisi;

        public HashMap()
        {
            HashDizisi = new HashEntry[Alfabe.Length];
            for (int i = 0; i < Alfabe.Length; i++)
            {
                HashDizisi[i] = new HashEntry();
            }
        }

        public void Insert(HeapAgacNode Girdi)
        {
            HashNode Ekleme = new HashNode();
            Ekleme.KullanimSayi = Girdi.KullanimSayi;
            Ekleme.Kelime = Girdi.Kelime;
            Ekleme.Konum = Girdi.Konum;
            Ekleme.Anahtar = Girdi.Kelime;
            for(int i = 0; i < Alfabe.Length; i++)
            {
                if (HashDizisi[i].Boyut == 0)
                {
                    HashDizisi[i].Anahtar = Convert.ToString(Ekleme.Anahtar[0]);
                    HashDizisi[i].Insert(Ekleme);
                    break;
                }
                else if (HashDizisi[i].Anahtar[0] == Ekleme.Anahtar[0])
                {
                    HashDizisi[i].Insert(Ekleme);
                    break;
                }
            }
        }
    }
}
