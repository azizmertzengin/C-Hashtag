using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siralaButon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Button> butonlar = new List<Button>();
        Random rnd = new Random();
        int[] sayilar = new int[9];
        int saniye = 60;
        int sayac = 0;
        bool checker = false;
        private void gameOver()
        {
            sayac = 0;
            timer1.Stop();
            checker = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!checker)
            {
                listBox1.Items.Clear();
                checker = true;
                for (int i = 0; i < 9; i++)
                {
                    sayilar[i] = rnd.Next(0, 100);
                    Button btn = new Button();
                    btn.Text = sayilar[i].ToString();
                    btn.Name = "buton" + i.ToString();
                    btn.SetBounds(groupBox1.Width - rnd.Next(0, groupBox1.Width - 75), groupBox1.Height - rnd.Next(0, groupBox1.Height - 75), 50, 50);
                    btn.ForeColor = Color.Black;
                    btn.BackColor = Color.Lime;
                    this.Controls.Add(btn);
                    butonlar.Add(btn);
                    btn.Click += new EventHandler(Btn_Click);
                }
                groupBox1.SendToBack();
                Array.Sort(sayilar);
                saniye = 60;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Oyun zaten devam ediyor.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            if (Convert.ToInt32(btn.Text) == sayilar[sayac])
            {
                listBox1.Items.Add(btn.Text);
                btn.Visible = false;
                sayac++;
                if (sayac == 9)
                {
                    gameOver();
                    MessageBox.Show(saniye.ToString() + " Sn kala oyunu bitirdin.", Name = "Tebriks");
                }
            }
            else
            {
                MessageBox.Show("Daha küçük sayılar var. Dikkatli ol oyun tuzaklı olabilir!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            label1.Text = "SÜRE: " + saniye.ToString() + " SN";
            if (saniye <= 0)
            {
                //Butonları gizleme fonksiyonu eklenmesi gerek**
                gameOver();
                MessageBox.Show("Süre bitti. Maalesef bölümü geçemedin.", Name = ":(");
            }
        }
    }
}
