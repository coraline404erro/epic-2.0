using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace epic_2._0
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            axWindowsMediaPlayer1.close();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(axWindowsMediaPlayer1);
            axWindowsMediaPlayer1 = null;

            foreach (var process in Process.GetProcessesByName("epic 2.0"))
            {
                try { process.Kill(); }
                catch { /* Ignora exceções */ }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
