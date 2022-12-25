using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int sec; //Saniye
        int min; //Dakika
        public static string kadi = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Başlat" || button1.Text == "Devam Et")
            {
                timer1.Start();
                button1.Text = "Tur";
                button2.Text = "Duraklat";
            }
            //Buton1'in adı Başlat veya Devam Et ise kronometreyi başlatıyor ve Button1'in adını Tur, 2'nin adını Duraklat haline getiriyor
            else if (button1.Text == "Tur")
            {
                label2.Text = label1.Text;
            }
            //Buton1'in adı Tur ise label1'in textini label2'ye geçiriyor. (Basıldığı andaki süreyi label2'ye aktarıyor.)
        }
        //Buton1'e tıklandığında altındaki işlemleri yapmaya başlar.
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Duraklat")
            {
                if (button1.Text == "Tur")
                {
                    timer1.Stop();
                    button2.Text = "Temizle";
                    button1.Text = "Devam Et";
                }
                //Buton1'in adı Tur olduğunda Timer1'i durdurur. Buton2'nin adını Temizle 1'in adını Devam Et yapar.
            }
            //Button2'nin adı Duraklat olduğunda if bloğuna girer.
            else if (button2.Text == "Temizle")
            {
                sec = 0;
                min = 0;
                label1.Text = "00:00";
                progressBar1.Value = 0;
                label2.Text = "";
                button1.Text = "Başlat";
                button2.Text = "Duraklat";
            }
            //Button2'nin adı Temizle olduğunda formu açılış ekranındaki haline döndürür.
        }
        //Buton2'ye tıklandığında altındaki işlemleri yapar.
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = sec;
            if (sec == 60)
            {
                min++;
                sec = -1;
            }
            //Saniye 60 olduğunda dakikaya 1 ekleyip saniyeyi -1'e çekiyor.

            sec++;

            if (min == 99 && sec == 60)
            {
                timer1.Stop();
            }
            //Dakika 99 ve saniye 60 olduğunda kronometreyi durduruyor.
            else if (min < 10 && sec < 10)
            {
                label1.Text = "0" + Convert.ToString(min) + ":" + "0" + Convert.ToString(sec);
            }
            //Dakika ve saniye 10'dan küçük olduğunda bu değerlerin başına 0 ekliyor ve dakikayla saniye arasına iki nokta (:) koyuyor.
            else if (sec >= 10 && min >= 10)
            {
                label1.Text = Convert.ToString(min) + ":" + Convert.ToString(sec);
            }
            //Saniye ve dakika 10'dan büyük veya eşit olduğunda direkt olarak sayıları yazıyor ve dakikayla saniye arasına iki nokta (:) koyuyor.
            else if (sec >= 10 && min < 10)
            {
                label1.Text = "0" + Convert.ToString(min) + ":" + Convert.ToString(sec);
            }
            //Saniye 10'dan büyük veya eşit ve dakika 10'dan küçük olduğunda dakikanın başına 0 ekleyip saniyeyi direkt yazıyor ve dakikayla saniye arasına iki nokta (:) koyuyor.
            else if (sec < 10 && min >= 10)
            {
                label1.Text = Convert.ToString(min) + ":" + "0" + Convert.ToString(sec);
            }
            //Saniye 10'dan küçük ve dakika 10'dan büyük veya eşit olduğunda saniyenin başına 0 ekleyip dakikayı direkt yazıyor ve dakikayla saniye arasına iki nokta (:) koyuyor.
        }
        //Timer1 her interval'ini bire defa döndürdüğünde yapacaklarını listeler

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }
        private void aquaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = kadi;
        }
    }
}
