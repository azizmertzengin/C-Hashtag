using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Minecraft_Auto_Sell
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process p = Process.GetProcessesByName("javaw").FirstOrDefault();
            if (p != null)
            {
                IntPtr h = p.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("t");
                System.Threading.Thread.Sleep(90);
                SendKeys.SendWait("/sell hand");
                SendKeys.Send("{ENTER}");
                System.Threading.Thread.Sleep(90);
                SendKeys.Send("%({TAB})");
                button2.Enabled = true;
                button1.Enabled = false;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Minecraft Not Found");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process p = Process.GetProcessesByName("javaw").FirstOrDefault();
            if (p != null)
            {
                IntPtr h = p.MainWindowHandle;
                SetForegroundWindow(h);
                SendKeys.SendWait("t");
                System.Threading.Thread.Sleep(90);
                SendKeys.SendWait("/sell hand");
                SendKeys.Send("{ENTER}");
                System.Threading.Thread.Sleep(90);
                SendKeys.Send("%({TAB})");
            }
        }
    }
}
