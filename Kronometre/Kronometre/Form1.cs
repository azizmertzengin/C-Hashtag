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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 frm2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Saintethic" && maskedTextBox1.Text == "admin" || comboBox1.Text == "root" && maskedTextBox1.Text == "toor")
            {
                Form2.kadi = comboBox1.Text;
                MessageBox.Show("Form'a sağ tıklayarak renk değiştirebilir veya çıkış yapabilirsiniz.");
                this.Hide();
                frm2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                maskedTextBox1.Text = "admin";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                maskedTextBox1.Text = "toor";
            }
            maskedTextBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void aquaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
    }
}
