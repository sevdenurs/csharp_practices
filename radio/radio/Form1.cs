using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "\thttp://46.20.7.125/listen.pls";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "\thttp://46.20.7.125/listen.pls";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "http://45.32.154.169:9300/;";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
       
}
