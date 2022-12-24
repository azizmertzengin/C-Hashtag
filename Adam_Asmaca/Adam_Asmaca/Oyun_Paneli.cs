using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Asmaca
{
    public partial class Oyun_Paneli : Form
    {
        public Oyun_Paneli()
        {
            InitializeComponent();
        }
        Sonuc form3 = new Sonuc();
        public static int pbv = 0;
        int check = 0;
//FUNCTIONS START   
        void formdegis()
        {
            pbv = progressBar1.Value;
           this.Hide();
           form3.ShowDialog();
           this.Close();
        }

        void controlet()
        {
            progressBar1.Value += 1;
            if (progressBar1.Value == 2)
            {
                this.Height = 435;
                this.Width = 484;
                pictureBox6.Visible = true;
            }
            else if (progressBar1.Value == 4)
            {
                pictureBox6.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (progressBar1.Value == 6)
            {
                pictureBox5.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (progressBar1.Value == 8)
            {
                pictureBox4.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (progressBar1.Value == 10)
            {
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
            }

            else if (progressBar1.Value == 12)
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
                MessageBox.Show("Oyunu kaybettiniz. Adamınız öldü.");
                formdegis();
                form3.puan = 0;
            }
        }
//FUNCTIONS END
        private void Oyun_Paneli_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

            Random rnd = new Random();
            string[] kelime = new string[] { "elalem", "deneme", "heyhey", "zengin", "batman", "baykuş", "bağdat", "atmaca", "bülbül", "abanoz" };
            int rndnum = rnd.Next(1, 10);
            string secilen = kelime[rndnum];
            label1.Text = secilen[0].ToString();
            label2.Text = secilen[1].ToString();
            label3.Text = secilen[2].ToString();
            label4.Text = secilen[3].ToString();
            label5.Text = secilen[4].ToString();
            label6.Text = secilen[5].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != label1.Text)
            {
                textBox1.Text = "";
                controlet();
            }
            else
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != label2.Text)
            {
                textBox2.Text = "";
                controlet();
            }
            else
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != label3.Text)
            {
                textBox3.Text = "";
                controlet();
            }
            else
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != label4.Text)
            {
                textBox4.Text = "";
                controlet();
            }
            else
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != label5.Text)
            {
                textBox5.Text = "";
                controlet();
            }
            else
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != label6.Text)
            {
                textBox6.Text = "";
                controlet();
            }
            else
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == label1.Text)
            {
                if (textBox2.Text == label2.Text)
                {
                    if (textBox3.Text == label3.Text)
                    {
                        if (textBox4.Text == label4.Text)
                        {
                            if (textBox5.Text == label5.Text)
                            {
                                if (textBox6.Text == label6.Text)
                                {
                                    formdegis();
                                }
                                else
                                {
                                    MessageBox.Show("Hatan var tekrar bak.");
            }
                            }
                            else
                            {
                                MessageBox.Show("Hatan var tekrar bak.");
            }
                        }
                        else
                        {
                            MessageBox.Show("Hatan var tekrar bak.");
            }
                    }
                    else
                    {
                        MessageBox.Show("Hatan var tekrar bak.");
            }
                }
                else
                {
                    MessageBox.Show("Hatan var tekrar bak.");
            }
            }
            else
            {
                MessageBox.Show("Hatan var tekrar bak.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check < 2)
            {
                check++;
                if (textBox1.Text != label1.Text)
                {
                    textBox1.Text = label1.Text;
                    textBox1.Enabled = false;
                }
                else if (textBox2.Text != label2.Text)
                {
                    textBox2.Text = label2.Text;
                    textBox2.Enabled = false;
                }
                else if (textBox3.Text != label3.Text)
                {
                    textBox3.Text = label3.Text;
                    textBox3.Enabled = false;
                }
                else if (textBox4.Text != label4.Text)
                {
                    textBox4.Text = label4.Text;
                    textBox4.Enabled = false;
                }
                else if (textBox5.Text != label5.Text)
                {
                    textBox5.Text = label5.Text;
                    textBox5.Enabled = false;
                }
                else if (textBox6.Text != label6.Text)
                {
                    textBox6.Text = label6.Text;
                    textBox6.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Maalesef Joker hakkınız kalmamış :/");
                button2.Enabled = false;
            }
        }
    }
}
