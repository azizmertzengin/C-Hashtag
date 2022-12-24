using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Asmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string adsoyad;
        private void button1_Click(object sender, EventArgs e)
        {
            adsoyad = textBox1.Text;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("Giriş işleminiz başarıyla tamamlandı. Oyuna yönlendiriliyorsunuz. Bütün cevaplarınızı küçük harflerle veriniz!");
                Oyun_Paneli form2 = new Oyun_Paneli();
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
        }
    }
}
