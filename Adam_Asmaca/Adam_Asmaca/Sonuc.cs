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
    public partial class Sonuc : Form
    {
        public Sonuc()
        {
            InitializeComponent();
        }
        public int puan = 0;
        private void Sonuc_Load(object sender, EventArgs e)
        {
            if (Oyun_Paneli.pbv  == 0)
            {
                puan = 100;
            }
            else if (Oyun_Paneli.pbv == 12)
            {
                puan = 0;
            }
            else
            {
                puan = 100 / (Oyun_Paneli.pbv/2);
            }
            label1.Text = Form1.adsoyad;
            label3.Text = puan.ToString();
        }
    }
}
