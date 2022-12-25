using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sonKullanici = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            dersBox1.Items.Add("Bilgisayar Donanımı");
            dersBox1.Items.Add("Görsel Programlama I");
            dersBox1.Items.Add("Grafik Animasyon I");
            dersBox1.Items.Add("İş Sağlığı ve Güvenliği");
            dersBox1.Items.Add("İşletim Sistemleri II");
            dersBox1.Items.Add("Veri Tabanı Yönetim Sistemleri");
            dersBox1.Items.Add("İngilizce II");
            dersBox1.Items.Add("Türk Dili II");

            dersBox2.Items.Add("Bilgisayar Donanımı");
            dersBox2.Items.Add("Görsel Programlama I");
            dersBox2.Items.Add("Grafik Animasyon I");
            dersBox2.Items.Add("İş Sağlığı ve Güvenliği");
            dersBox2.Items.Add("İşletim Sistemleri II");
            dersBox2.Items.Add("Veri Tabanı Yönetim Sistemleri");
            dersBox2.Items.Add("İngilizce II");
            dersBox2.Items.Add("Türk Dili II");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtAd.Text, txtYas.Text, dersBox1.Text, txtVize.Text, txtFinal.Text, (Convert.ToInt32(txtVize.Text) * 0.2) + (Convert.ToInt32(txtFinal.Text) * 0.8));
            if (Convert.ToInt32(dataGridView1.Rows[sonKullanici].Cells[5].Value) >= 35)
            {
                dataGridView1.Rows[sonKullanici].Cells[6].Value = "GEÇTİ";
                dataGridView1.Rows[sonKullanici].Cells[6].Style.BackColor = Color.Green;
            }
            else
            {
                dataGridView1.Rows[sonKullanici].Cells[6].Value = "KALDI";
                dataGridView1.Rows[sonKullanici].Cells[6].Style.BackColor = Color.Red;
            }
            sonKullanici++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            double geneltoplam = 0;
            int ortBolen = 0;
            for (int i = 0; i < sonKullanici; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Text)
                {
                    toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    ortBolen++;
                }
                else if (dersBox2.Text == "")
                {
                    geneltoplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    ortBolen++;
                }
            }
            if (toplam > 0)
            {
                dataGridView2.Rows.Add(dersBox2.Text, (toplam / ortBolen));
            }
            else if (dersBox2.Text == "")
            {
                dataGridView2.Rows.Add("Genel", (geneltoplam / ortBolen));
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int hesapla = 0;
            double[] notlar = new double[sonKullanici + 1];
            Array.Clear(notlar, 0, notlar.Length);
            if (dersBox2.Text != "")
            {
                notlar = new double[sonKullanici + 1];
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Text)
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        hesapla++;
                    }
                }
                Array.Sort(notlar);
                if (hesapla == 0)
                {
                    hesapla = 1;
                }
                dataGridView3.Rows.Add(dersBox2.Text, notlar[sonKullanici], notlar[sonKullanici + 1 - hesapla]);
                hesapla = 0;
            }

            else if (dersBox2.Text == "")
            {
                notlar = new double[sonKullanici + 1];
                Array.Clear(notlar, 0, notlar.Length);
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Bilgisayar Donanımı")
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        hesapla++;
                    }
                }
                Array.Sort(notlar);
                if (hesapla == 0)
                {
                    hesapla = 1;
                }
                dataGridView3.Rows.Add("Bilgisayar Donanımı", notlar[sonKullanici], notlar[sonKullanici + 1 - hesapla]);
                hesapla = 0;

                Array.Clear(notlar, 0, notlar.Length);
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Görsel Programlama I")
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        hesapla++;
                    }
                }
                Array.Sort(notlar);
                if (hesapla == 0)
                {
                    hesapla = 1;
                }
                dataGridView3.Rows.Add("Görsel Programlama I", notlar[sonKullanici], notlar[sonKullanici + 1 - hesapla]);
                hesapla = 0;

                Array.Clear(notlar, 0, notlar.Length);
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Grafik Animasyon I")
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        hesapla++;
                    }
                }
                Array.Sort(notlar);
                if (hesapla == 0)
                {
                    hesapla = 1;
                }
                dataGridView3.Rows.Add("Grafik Animasyon I", notlar[sonKullanici], notlar[sonKullanici + 1 - hesapla]);
                hesapla = 0;

                Array.Clear(notlar, 0, notlar.Length);
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "İş Sağlığı ve Güvenliği")
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        hesapla++;
                    }
                }
                Array.Sort(notlar);
                if (hesapla == 0)
                {
                    hesapla = 1;
                }
                dataGridView3.Rows.Add("İş Sağlığı ve Güvenliği", notlar[sonKullanici], notlar[sonKullanici + 1 - hesapla]);
                hesapla = 0;

                Array.Clear(notlar, 0, notlar.Length);
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "İşletim Sistemleri II")
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        hesapla++;
                    }
                }
                Array.Sort(notlar);
                if (hesapla == 0)
                {
                    hesapla = 1;
                }
                dataGridView3.Rows.Add("İşletim Sistemleri II", notlar[sonKullanici], notlar[sonKullanici + 1 - hesapla]);
                hesapla = 0;

                Array.Clear(notlar, 0, notlar.Length);
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Veri Tabanı Yönetim Sistemleri")
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        hesapla++;
                    }
                }
                Array.Sort(notlar);
                if (hesapla == 0)
                {
                    hesapla = 1;
                }
                dataGridView3.Rows.Add("Veri Tabanı Yönetim Sistemleri", notlar[sonKullanici], notlar[sonKullanici + 1 - hesapla]);
                hesapla = 0;

                Array.Clear(notlar, 0, notlar.Length);
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "İngilizce II")
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        hesapla++;
                    }
                }
                Array.Sort(notlar);
                if (hesapla == 0)
                {
                    hesapla = 1;
                }
                dataGridView3.Rows.Add("İngilizce II", notlar[sonKullanici], notlar[sonKullanici + 1 - hesapla]);
                hesapla = 0;

                Array.Clear(notlar, 0, notlar.Length);
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Türk Dili II")
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        hesapla++;
                    }
                }
                Array.Sort(notlar);
                if (hesapla == 0)
                {
                    hesapla = 1;
                }
                dataGridView3.Rows.Add("Türk Dili II", notlar[sonKullanici], notlar[sonKullanici + 1 - hesapla]);
                hesapla = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int gecenOgrenci = 0;
            if (dersBox2.Text != "")
            {
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) >= 35)
                    {
                        gecenOgrenci++;
                    }
                }
                dataGridView4.Rows.Add(dersBox2.Text, gecenOgrenci);
            }

            else if (dersBox2.Text == "")
            {
                gecenOgrenci = 0;
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Bilgisayar Donanımı")
                    {
                        if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) >= 35)
                        {
                            gecenOgrenci++;
                        }
                    }
                }
                dataGridView4.Rows.Add("Bilgisayar Donanımı", gecenOgrenci);

                gecenOgrenci = 0;
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Görsel Programlama I")
                    {
                        if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) >= 35)
                        {
                            gecenOgrenci++;
                        }
                    }
                }
                dataGridView4.Rows.Add("Görsel Programlama I", gecenOgrenci);

                gecenOgrenci = 0;
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Grafik Animasyon I")
                    {
                        if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) >= 35)
                        {
                            gecenOgrenci++;
                        }
                    }
                }
                dataGridView4.Rows.Add("Grafik Animasyon I", gecenOgrenci);

                gecenOgrenci = 0;
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "İş Sağlığı ve Güvenliği")
                    {
                        if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) >= 35)
                        {
                            gecenOgrenci++;
                        }
                    }
                }
                dataGridView4.Rows.Add("İş Sağlığı ve Güvenliği", gecenOgrenci);

                gecenOgrenci = 0;
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "İşletim Sistemleri II")
                    {
                        if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) >= 35)
                        {
                            gecenOgrenci++;
                        }
                    }
                }
                dataGridView4.Rows.Add("İşletim Sistemleri II", gecenOgrenci);

                gecenOgrenci = 0;
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Veri Tabanı Yönetim Sistemleri")
                    {
                        if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) >= 35)
                        {
                            gecenOgrenci++;
                        }
                    }
                }
                dataGridView4.Rows.Add("Veri Tabanı Yönetim Sistemleri", gecenOgrenci);

                gecenOgrenci = 0;
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "İngilizce II")
                    {
                        if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) >= 35)
                        {
                            gecenOgrenci++;
                        }
                    }
                }
                dataGridView4.Rows.Add("İngilizce II", gecenOgrenci);

                gecenOgrenci = 0;
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Türk Dili II")
                    {
                        if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) >= 35)
                        {
                            gecenOgrenci++;
                        }
                    }
                }
                dataGridView4.Rows.Add("Türk Dili II", gecenOgrenci);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sonKullanici + 1; i++)
            {
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) == 35)
                {
                    dataGridView10.Rows.Add(dataGridView1.Rows[i].Cells[2].Value, dataGridView1.Rows[i].Cells[0].Value, dataGridView1.Rows[i].Cells[5].Value);
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Aqua; //Blue yapmıştım fakat okuyamadığım için mavinin tonu olan Aqua olarak değiştirdim.
                    dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Aqua; //Blue yapmıştım fakat okuyamadığım için mavinin tonu olan Aqua olarak değiştirdim.
                    dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Aqua; //Blue yapmıştım fakat okuyamadığım için mavinin tonu olan Aqua olarak değiştirdim.
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double donanim = 0;
            double gorsel = 0;
            double grafik = 0;
            double isSagligi = 0;
            double isletimSistemleri = 0;
            double veriTabani = 0;
            double ingilizce = 0;
            double turkce = 0;
            int ortBolen = 0;


            for (int i = 0; i < sonKullanici + 1; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Bilgisayar Donanımı")
                {
                    donanim += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    ortBolen++;
                }
            }
            donanim = donanim / ortBolen;
            ortBolen = 0;

            for (int i = 0; i < sonKullanici + 1; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Görsel Programlama I")
                {
                    gorsel += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    ortBolen++;
                }
            }
            gorsel = gorsel / ortBolen;
            ortBolen = 0;


            for (int i = 0; i < sonKullanici + 1; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Grafik Animasyon I")
                {
                    grafik += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    ortBolen++;
                }
            }
            grafik = grafik / ortBolen;
            ortBolen = 0;


            for (int i = 0; i < sonKullanici + 1; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "İş Sağlığı ve Güvenliği")
                {
                    isSagligi += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    ortBolen++;
                }
            }
            isSagligi = isSagligi / ortBolen;
            ortBolen = 0;


            for (int i = 0; i < sonKullanici + 1; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "İşletim Sistemleri II")
                {
                    isletimSistemleri += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    ortBolen++;
                }
            }
            isletimSistemleri = isletimSistemleri / ortBolen;
            ortBolen = 0;


            for (int i = 0; i < sonKullanici + 1; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Veri Tabanı Yönetim Sistemleri")
                {
                    veriTabani += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    ortBolen++;
                }
            }
            veriTabani = veriTabani / ortBolen;
            ortBolen = 0;


            for (int i = 0; i < sonKullanici + 1; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "İngilizce II")
                {
                    ingilizce += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    ortBolen++;
                }
            }
            ingilizce = ingilizce / ortBolen;
            ortBolen = 0;


            for (int i = 0; i < sonKullanici + 1; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "İngilizce II")
                {
                    ingilizce += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    ortBolen++;
                }
            }
            ingilizce = ingilizce / ortBolen;
            ortBolen = 0;


            for (int i = 0; i < sonKullanici + 1; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == "Türk Dili II")
                {
                    turkce += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    ortBolen++;
                }
            }
            turkce = turkce / ortBolen;
            ortBolen = 0;


            double[] siralama = { donanim, gorsel, grafik, isSagligi, isletimSistemleri, turkce, ingilizce, veriTabani };
            Array.Sort(siralama);


            if (siralama[7] == donanim)
            {
                dataGridView9.Rows.Add("Bilgisayar Donanımı", siralama[7]);
            }

            else if (siralama[7] == gorsel)
            {
                dataGridView9.Rows.Add("Görsel Programlama I", siralama[7]);
            }

            else if (siralama[7] == grafik)
            {
                dataGridView9.Rows.Add("Grafik Animasyon I", siralama[7]);
            }

            else if (siralama[7] == isSagligi)
            {
                dataGridView9.Rows.Add("İş Sağlığı ve Güvenliği", siralama[7]);
            }

            else if (siralama[7] == isletimSistemleri)
            {
                dataGridView9.Rows.Add("İşletim Sistemleri II", siralama[7]);
            }

            else if (siralama[7] == veriTabani)
            {
                dataGridView9.Rows.Add("Veri Tabanı Yönetim Sistemleri", siralama[7]);
            }

            else if (siralama[7] == ingilizce)
            {
                dataGridView9.Rows.Add("İngilizce II", siralama[7]);
            }

            else if (siralama[7] == turkce)
            {
                dataGridView9.Rows.Add("Türk Dili II", siralama[7]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sonKullanici; i++)
            {
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) < 35)
                {
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.White;
                }

                else if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) >= 35)
                {
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                    dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.Red;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double enYuksek = 0;
            string dersAdi = "";
            string ogrenciAdi = "";

            for (int i = 0; i < sonKullanici; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "Bilgisayar Donanımı")
                {
                    if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) > enYuksek)
                    {
                        enYuksek = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        dersAdi = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        ogrenciAdi = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    }
                }
            }
            if (dersAdi != "")
            {
                dataGridView8.Rows.Add(dersAdi, ogrenciAdi, enYuksek);
            }
            enYuksek = 0;
            ogrenciAdi = "";
            dersAdi = "";

            for (int i = 0; i < sonKullanici; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "Görsel Programlama I")
                {
                    if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) > enYuksek)
                    {
                        enYuksek = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        dersAdi = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        ogrenciAdi = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    }
                }
            }
            if (dersAdi != "")
            {
                dataGridView8.Rows.Add(dersAdi, ogrenciAdi, enYuksek);
            }
            enYuksek = 0;
            ogrenciAdi = "";
            dersAdi = "";

            for (int i = 0; i < sonKullanici; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "Grafik Animasyon I")
                {
                    if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) > enYuksek)
                    {
                        enYuksek = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        dersAdi = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        ogrenciAdi = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    }
                }
            }
            if (dersAdi != "")
            {
                dataGridView8.Rows.Add(dersAdi, ogrenciAdi, enYuksek);
            }
            enYuksek = 0;
            ogrenciAdi = "";
            dersAdi = "";

            for (int i = 0; i < sonKullanici; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "İş Sağlığı ve Güvenliği")
                {
                    if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) > enYuksek)
                    {
                        enYuksek = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        dersAdi = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        ogrenciAdi = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    }
                }
            }
            if (dersAdi != "")
            {
                dataGridView8.Rows.Add(dersAdi, ogrenciAdi, enYuksek);
            }
            enYuksek = 0;
            ogrenciAdi = "";
            dersAdi = "";

            for (int i = 0; i < sonKullanici; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "İşletim Sistemleri II")
                {
                    if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) > enYuksek)
                    {
                        enYuksek = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        dersAdi = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        ogrenciAdi = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    }
                }
            }
            if (dersAdi != "")
            {
                dataGridView8.Rows.Add(dersAdi, ogrenciAdi, enYuksek);
            }
            enYuksek = 0;
            ogrenciAdi = "";
            dersAdi = "";

            for (int i = 0; i < sonKullanici; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "Veri Tabanı Yönetim Sistemleri")
                {
                    if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) > enYuksek)
                    {
                        enYuksek = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        dersAdi = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        ogrenciAdi = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    }
                }
            }
            if (dersAdi != "")
            {
                dataGridView8.Rows.Add(dersAdi, ogrenciAdi, enYuksek);
            }
            enYuksek = 0;
            ogrenciAdi = "";
            dersAdi = "";

            for (int i = 0; i < sonKullanici; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "İngilizce II")
                {
                    if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) > enYuksek)
                    {
                        enYuksek = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        dersAdi = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        ogrenciAdi = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    }
                }
            }
            if (dersAdi != "")
            {
                dataGridView8.Rows.Add(dersAdi, ogrenciAdi, enYuksek);
            }
            enYuksek = 0;
            ogrenciAdi = "";
            dersAdi = "";

            for (int i = 0; i < sonKullanici; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "Türk Dili II")
                {
                    if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) > enYuksek)
                    {
                        enYuksek = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        dersAdi = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        ogrenciAdi = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    }
                }
            }
            if (dersAdi != "")
            {
                dataGridView8.Rows.Add(dersAdi, ogrenciAdi, enYuksek);
            }
            enYuksek = 0;
            ogrenciAdi = "";
            dersAdi = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int yas = 0;
            string kisi = "";
            string ders = "";
            if (dersBox2.Text != "")
            {
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Text)
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) > yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }

                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Text)
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) < yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }
            }



            else if (dersBox2.Text == "")
            {
                yas = 0;
                kisi = "";
                ders = "";
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox1.Items[0].ToString())
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) > yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }

                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox1.Items[0].ToString())
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) < yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }

                yas = 0;
                kisi = "";
                ders = "";
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox1.Items[1].ToString())
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) > yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }

                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox1.Items[1].ToString())
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) < yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }

                yas = 0;
                kisi = "";
                ders = "";
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox1.Items[2].ToString())
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) > yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }

                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox1.Items[2].ToString())
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) < yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }

                yas = 0;
                kisi = "";
                ders = "";
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox1.Items[3].ToString())
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) > yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }

                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox1.Items[3].ToString())
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) < yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }

                yas = 0;
                kisi = "";
                ders = "";
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox1.Items[4].ToString())
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) > yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }

                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox1.Items[4].ToString())
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) < yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }

                yas = 0;
                kisi = "";
                ders = "";
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox1.Items[5].ToString())
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) > yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }

                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox1.Items[5].ToString())
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) < yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }

                yas = 0;
                kisi = "";
                ders = "";
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox1.Items[6].ToString())
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) > yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }

                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox1.Items[6].ToString())
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) < yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }

                yas = 0;
                kisi = "";
                ders = "";
                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox1.Items[7].ToString())
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) > yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }

                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox1.Items[7].ToString())
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) < yas)
                        {
                            kisi = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                            yas = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                            ders = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                        }
                    }
                }
                if (ders != "")
                {
                    dataGridView5.Rows.Add(ders, kisi, yas);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Ders'e o öğrenci sınava girmemiş olsa da en sonuncuya yazılıyor çünkü girmeyen öğrenci mantıken en düşük alan sayılıyor. Eğer o dersin sınavına hiçkimse girmemişse en düşük not aynı zamanda en yüksek not olduğu için sıralamaya yine de 1 yazıyor.


            double[] notlar = new double[sonKullanici + 1];
            double ogrenciNot = 0;
            int sira = 0;

            if (dersBox2.Text != "")
            {
                for (int i = 0; i < sonKullanici; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Text)
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == txtAd.Text)
                        {
                            ogrenciNot = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        }
                    }
                }

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Text)
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    }
                }

                Array.Sort(notlar);
                Array.Reverse(notlar);

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (notlar[i] != ogrenciNot)
                    {
                        sira++;
                    }

                    if (notlar[i] == ogrenciNot)
                    {
                        dataGridView6.Rows.Add(dersBox2.Text, sira + 1);
                        return;
                    }
                }
            }

            if (dersBox2.Text == "")
            {
                Array.Clear(notlar, 0, notlar.Length);
                ogrenciNot = 0;
                sira = 0;

                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Items[0].ToString())
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == txtAd.Text)
                        {
                            ogrenciNot = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        }
                    }
                }

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Items[0].ToString())
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    }
                }

                Array.Sort(notlar);
                Array.Reverse(notlar);

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (notlar[i] != ogrenciNot)
                    {
                        sira++;
                    }

                    if (notlar[i] == ogrenciNot)
                    {
                        dataGridView6.Rows.Add(dersBox2.Items[0].ToString(), sira + 1);
                        goto items1;
                    }
                }
                items1:
                Array.Clear(notlar, 0, notlar.Length);
                ogrenciNot = 0;
                sira = 0;

                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Items[1].ToString())
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == txtAd.Text)
                        {
                            ogrenciNot = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        }
                    }
                }

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Items[1].ToString())
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    }
                }

                Array.Sort(notlar);
                Array.Reverse(notlar);

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (notlar[i] != ogrenciNot)
                    {
                        sira++;
                    }

                    if (notlar[i] == ogrenciNot)
                    {
                        dataGridView6.Rows.Add(dersBox2.Items[1].ToString(), sira + 1);
                        goto items2;
                    }
                }
                items2:
                Array.Clear(notlar, 0, notlar.Length);
                ogrenciNot = 0;
                sira = 0;

                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Items[2].ToString())
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == txtAd.Text)
                        {
                            ogrenciNot = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        }
                    }
                }

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Items[2].ToString())
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    }
                }

                Array.Sort(notlar);
                Array.Reverse(notlar);

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (notlar[i] != ogrenciNot)
                    {
                        sira++;
                    }

                    if (notlar[i] == ogrenciNot)
                    {
                        dataGridView6.Rows.Add(dersBox2.Items[2].ToString(), sira + 1);
                        goto items3;
                    }
                }
                items3:
                Array.Clear(notlar, 0, notlar.Length);
                ogrenciNot = 0;
                sira = 0;

                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Items[3].ToString())
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == txtAd.Text)
                        {
                            ogrenciNot = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        }
                    }
                }

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Items[3].ToString())
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    }
                }

                Array.Sort(notlar);
                Array.Reverse(notlar);

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (notlar[i] != ogrenciNot)
                    {
                        sira++;
                    }

                    if (notlar[i] == ogrenciNot)
                    {
                        dataGridView6.Rows.Add(dersBox2.Items[3].ToString(), sira + 1);
                        goto items4;
                    }
                }
                items4:
                Array.Clear(notlar, 0, notlar.Length);
                ogrenciNot = 0;
                sira = 0;

                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Items[4].ToString())
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == txtAd.Text)
                        {
                            ogrenciNot = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        }
                    }
                }

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Items[4].ToString())
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    }
                }

                Array.Sort(notlar);
                Array.Reverse(notlar);

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (notlar[i] != ogrenciNot)
                    {
                        sira++;
                    }

                    if (notlar[i] == ogrenciNot)
                    {
                        dataGridView6.Rows.Add(dersBox2.Items[4].ToString(), sira + 1);
                        goto items5;
                    }
                }
                items5:
                Array.Clear(notlar, 0, notlar.Length);
                ogrenciNot = 0;
                sira = 0;

                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Items[5].ToString())
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == txtAd.Text)
                        {
                            ogrenciNot = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        }
                    }
                }

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Items[5].ToString())
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    }
                }

                Array.Sort(notlar);
                Array.Reverse(notlar);

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (notlar[i] != ogrenciNot)
                    {
                        sira++;
                    }

                    if (notlar[i] == ogrenciNot)
                    {
                        dataGridView6.Rows.Add(dersBox2.Items[5].ToString(), sira + 1);
                        goto items6;
                    }
                }
                items6:
                Array.Clear(notlar, 0, notlar.Length);
                ogrenciNot = 0;
                sira = 0;

                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Items[6].ToString())
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == txtAd.Text)
                        {
                            ogrenciNot = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        }
                    }
                }

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Items[6].ToString())
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    }
                }

                Array.Sort(notlar);
                Array.Reverse(notlar);

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (notlar[i] != ogrenciNot)
                    {
                        sira++;
                    }

                    if (notlar[i] == ogrenciNot)
                    {
                        dataGridView6.Rows.Add(dersBox2.Items[6].ToString(), sira + 1);
                        goto items7;
                    }
                }
                items7:
                Array.Clear(notlar, 0, notlar.Length);
                ogrenciNot = 0;
                sira = 0;

                for (int i = 0; i < sonKullanici + 1; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Items[7].ToString())
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == txtAd.Text)
                        {
                            ogrenciNot = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        }
                    }
                }

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == dersBox2.Items[7].ToString())
                    {
                        notlar[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    }
                }

                Array.Sort(notlar);
                Array.Reverse(notlar);

                for (int i = 0; i < sonKullanici; i++)
                {
                    if (notlar[i] != ogrenciNot)
                    {
                        sira++;
                    }

                    if (notlar[i] == ogrenciNot)
                    {
                        dataGridView6.Rows.Add(dersBox2.Items[7].ToString(), sira + 1);
                        return;
                    }
                }
            }
        }
    }
}