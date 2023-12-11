using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\nurta\\OneDrive\\Masaüstü\\1.mp3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\nurta\\OneDrive\\Masaüstü\\1.mp3";
            pictureBox1.ImageLocation = "C:\\Users\\nurta\\OneDrive\\Masaüstü\\10.jpeg";
        }
    }
}
