using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar;
            int alan, cevre;

            birkenar =Convert.ToInt32(textBox1.Text);
            alan = birkenar * birkenar;
            cevre = 4 * birkenar;

            label4.Text = alan.ToString();
            label5.Text = cevre.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            textBox2.Visible = false;
        }
    }
}
