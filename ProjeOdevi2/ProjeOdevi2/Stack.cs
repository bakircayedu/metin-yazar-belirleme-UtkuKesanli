using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjeOdevi2
{
    public class Stack
    {
        public StackNode Head;
        public int CumleSayisi;
        public int ToplamKelime;

        public void DosyadanOku(string str)
        {
            //https://www.c-sharpcorner.com/UploadFile/mahesh/how-to-read-a-text-file-in-C-Sharp/
            string[] text = File.ReadAllText(str).Split('\n');
            CumleSayisi = text.Length;
            ToplamKelime = 0;

            foreach (string item in text)
            {
                Insert(item);
            }
        }

        public void Insert(string str)
        {
            StackNode tmp = Head;
           
            if (tmp == null)
            {
                Head = new StackNode(str);               
            }
            else
            {
                while (tmp != null)
                {
                    tmp = tmp.Next;
                }
                tmp = new StackNode(str);
                tmp.Next = Head;
                Head = tmp;
            }
            ToplamKelime += Head.KelimeSayisi;
        }

        public HeapAgac AgacaCevir()
        {
            StackNode tmp = Head;
            HeapAgac agc = new HeapAgac(ToplamKelime);
            bool eklendi = false;

            while (tmp != null)
            {
                for (int i = 0; i < tmp.Kelimeler.Length; i++)
                {
                    for (int j = 0; j < agc.Indeks; j++)
                    {
                        if (tmp.Kelimeler[i] == agc.HeapDizi[j].Kelime)
                        {
                            agc.HeapDizi[j].KullanimSayi++;
                            eklendi = true;
                            agc.YukariTasi(j);
                            break;
                        }
                    }
                    if (!eklendi)
                    {
                        agc.Insert(tmp.Kelimeler[i]);
                    }
                    eklendi = false;
                }

                tmp = tmp.Next;
            }

            return agc;
        }
    }
}
