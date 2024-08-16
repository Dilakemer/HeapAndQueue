using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VeriYapıları
{
    public partial class Form1 : Form
    {
        private OncelikliKuyruk kuyruk = new OncelikliKuyruk();

        public Form1()
        {
            InitializeComponent();
        }

        private void KuyrugaEkle_Click_1(object sender, EventArgs e)
        {
            string no = txtOgrNo.Text;
            string adsoyad = txtAdSoyad.Text;
            double diplomaNotu = Convert.ToDouble(txtOrt.Text); // Diploma notunu double olarak dönüştür
            int devamsizlik = Convert.ToInt32(txtDevamsizlik.Text); // Devamsızlığı integer olarak dönüştür
            bool GorevAlmaDurumu = checkBox1.Checked;

            // TextBox'ları temizleme işlemi 
            txtOgrNo.Clear();
            txtOrt.Clear();
            txtAdSoyad.Clear();
            txtDevamsizlik.Clear();

            Ogrenci yenikisi = new Ogrenci
            {
                No = no,
                AdSoyad = adsoyad,
                DiplomaNotu = diplomaNotu,
                Devamsizlik = devamsizlik,
                ToplulukGorevi = GorevAlmaDurumu
            };
            kuyruk.OgrenciEkle(yenikisi); // Öğrenciyi öncelikli kuyruğa ekle
            listeOgrenciler.Items.Add($"{adsoyad} - Diploma Notu: {diplomaNotu} - Görev Alıyor Mu: {GorevAlmaDurumu}");
        }

        private void KuyruktanCikar_Click(object sender, EventArgs e)
        {
            Ogrenci cikarilanOgrenci = kuyruk.OgrenciCikar();

            if (cikarilanOgrenci != null)
            {
                // Listbox'taki ilk öğrenciyi çıkar
                listeOgrenciler.Items.RemoveAt(0);

                // Çıkarılan öğrencinin bilgilerini ekranda göster
                textBox5.Text = cikarilanOgrenci.No;
                textBox6.Text = cikarilanOgrenci.AdSoyad;
                textBox7.Text = cikarilanOgrenci.DiplomaNotu.ToString();
                textBox8.Text = cikarilanOgrenci.Devamsizlik.ToString();
                checkBox2.Checked = cikarilanOgrenci.ToplulukGorevi;
            }
            else
            {
                MessageBox.Show("Kuyruk boş!");
            }

            // Kuyruğu yeniden göster
            KuyruguGoster_Click(sender, e);
        }

        private void KuyruguGoster_Click(object sender, EventArgs e)
        {
            List<string> ogrenciListesi = kuyruk.GosterListe();
            listeOgrenciler.Items.Clear();
            listeOgrenciler.Items.AddRange(ogrenciListesi.ToArray());
        }
    }

    public class OncelikliKuyruk
    {
        private List<Ogrenci> kuyruk = new List<Ogrenci>();

        public void OgrenciEkle(Ogrenci ogrenci)
        {
            int index = 0;
            while (index < kuyruk.Count && (
                kuyruk[index].DiplomaNotu > ogrenci.DiplomaNotu ||
                (kuyruk[index].DiplomaNotu == ogrenci.DiplomaNotu && kuyruk[index].Devamsizlik < ogrenci.Devamsizlik) ||
                (kuyruk[index].DiplomaNotu == ogrenci.DiplomaNotu && kuyruk[index].Devamsizlik == ogrenci.Devamsizlik && kuyruk[index].ToplulukGorevi && !ogrenci.ToplulukGorevi)
            ))
            {
                index++;
            }
            kuyruk.Insert(index, ogrenci);
        }

        public Ogrenci OgrenciCikar()
        {
            if (kuyruk.Count == 0)
                return null;

            Ogrenci removed = kuyruk[0];
            kuyruk.RemoveAt(0);
            return removed;
        }

        public List<string> GosterListe()
        {
            List<string> liste = new List<string>();
            foreach (var ogrenci in kuyruk)
            {
                liste.Add($"Ad Soyad: {ogrenci.AdSoyad}, Diploma Notu: {ogrenci.DiplomaNotu}, Devamsızlık: {ogrenci.Devamsizlik}, Topluluk Görevi: {(ogrenci.ToplulukGorevi ? "Var" : "Yok")}");
            }
            return liste;
        }

        public void HeapSort(ListBox listBox)
        {
            int n = kuyruk.Count;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                Swap(0, i);
                Heapify(i, 0);
            }

            listBox.Items.Clear();
            foreach (var ogrenci in kuyruk)
            {
                listBox.Items.Add(ogrenci.ToString());
            }
        }

        private void Heapify(int n, int i)
        {
            int largest = i;
            int leftChild = 2 * i + 1;
            int rightChild = 2 * i + 2;

            if (leftChild < n && kuyruk[leftChild].DiplomaNotu > kuyruk[largest].DiplomaNotu)
            {
                largest = leftChild;
            }

            if (rightChild < n && kuyruk[rightChild].DiplomaNotu > kuyruk[largest].DiplomaNotu)
            {
                largest = rightChild;
            }

            if (largest != i)
            {
                Swap(i, largest);
                Heapify(n, largest);
            }
        }

        private void Swap(int i, int j)
        {
            Ogrenci temp = kuyruk[i];
            kuyruk[i] = kuyruk[j];
            kuyruk[j] = temp;
        }
    }

   
}
