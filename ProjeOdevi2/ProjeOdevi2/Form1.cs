using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdevi2
{
    public partial class Form1 : Form
    {
        static Stack Yigit = new Stack();
        static HeapAgac Agac = new HeapAgac(Yigit.ToplamKelime);
        static HashMap Hash = new HashMap();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMetinYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Dosyası |*.txt";
            file.ShowDialog();
            textBoxMetinOku.Text = file.FileName;
        }

        private void btnStackYukle_Click(object sender, EventArgs e)
        {
            Yigit.DosyadanOku(textBoxMetinOku.Text);
            listIstatistikler.Items.Clear();
            listIstatistikler.Items.Add("Toplam Kelime Sayısı : " + Convert.ToString(Yigit.ToplamKelime) + "\n");
            listIstatistikler.Items.Add("Toplam Cümle Sayısı : " + Convert.ToString(Yigit.CumleSayisi) + "\n");
            listIstatistikler.Items.Add("Metindeki Toplam Benzersiz Kelime Sayısı : " + Convert.ToString(Yigit.Head.KelimeSayisi) + "\n");
            listIstatistikler.Items.Add("Ortalam Kelime Sayısı : " + Convert.ToString((Yigit.ToplamKelime)/(Yigit.CumleSayisi)) + "\n");
        }

        private void btnAgacaAktar_Click(object sender, EventArgs e)
        {
            if (Yigit.Head == null)
            {
                MessageBox.Show("Öncelikle Sisteme Bir Dosya Yüklemelisiniz");
            }
            else
            {
                Agac = Yigit.AgacaCevir();
            }
        }

        private void btnEnCokKelimeler_Click(object sender, EventArgs e)
        {
            Agac.EnFazlalarıGetir(Agac.HeapDizi);
            listIstatistikler.Items.Clear();
            listIstatistikler.Items.Add("En Çok Kullanılan İlk 3 Kelime \n");
            listIstatistikler.Items.Add("-" + Convert.ToString(Agac.HeapDizi[0].Kelime));
            listIstatistikler.Items.Add("-" + Convert.ToString(Agac.HeapDizi[1].Kelime));
            listIstatistikler.Items.Add("-" + Convert.ToString(Agac.HeapDizi[2].Kelime));
        }

        private void btnHashTablosu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Agac.Indeks; i++)
            {
                Hash.Insert(Agac.HeapDizi[i]);
            }
        }
    }
}
