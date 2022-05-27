using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdevi2
{
    public class HeapAgac
    {
        public HeapAgacNode[] HeapDizi;
        public int MaxBoyut;
        public int Indeks;

        public HeapAgac(int Max)
        {
            MaxBoyut = Max;
            Indeks = 0;
            HeapDizi = new HeapAgacNode[MaxBoyut];
        }

        public bool IsEmpty()
        {
            return Indeks == 0;
        }

        public bool Insert(string str)
        {
            if (Indeks == MaxBoyut)
            {
                return false;
            }

            HeapAgacNode newHeapDugumu = new HeapAgacNode(str);
            HeapDizi[Indeks] = newHeapDugumu;
            YukariTasi(Indeks++);
            return true;
        }

        public void YukariTasi(int index)
        {
            int parent = (index - 1) / 2;
            HeapAgacNode bottom = HeapDizi[index];
            while (index > 0 && HeapDizi[parent].KullanimSayi < bottom.KullanimSayi)
            {
                HeapDizi[index] = HeapDizi[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            HeapDizi[index] = bottom;
        }

        public void EnFazlalarıGetir(HeapAgacNode[] Dizi)
        {
            Dizi = HeapSort(Dizi);
        }
        public HeapAgacNode[] HeapSort(HeapAgacNode[] heapTree)
        {
            int Sayac = 0;
            int tmp = Indeks;
            HeapAgacNode[] Siraliagac = new HeapAgacNode[heapTree.Length];
            while (tmp != 0)
            { 
                Siraliagac[Sayac] = MaksimumuBulma(--tmp);
                Sayac = Sayac + 1;
            }
            return Siraliagac;
        }
        public HeapAgacNode MaksimumuBulma(int i)
        {

            HeapAgacNode tmp = HeapDizi[0];
            HeapDizi[0] = HeapDizi[i];
            YukariTasi(0);
            return tmp;
        }
    }
}
