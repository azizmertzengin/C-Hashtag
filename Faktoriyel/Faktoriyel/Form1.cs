using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktoriyel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int sayi = 0;
        int hesapla = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            sayi = int.Parse(textBox1.Text);
         for (int i = 1; i <= sayi; i++)
            {
                hesapla *= i;
            }
            label1.Text = hesapla.ToString();
            hesapla = 1;
        }
    }
}
